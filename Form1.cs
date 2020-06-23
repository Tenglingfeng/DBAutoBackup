using Quartz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quartz.Impl;
using Quartz.Spi;

namespace SqlServerAutoBuckups
{
    public partial class SqlServer : Form
    {
        public SqlServer()
        {
            InitializeComponent();
        }

        public static SqlServer StaticForm1 { get; set; }

        /// <summary>
        /// 测试数据库连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Testconnection_Click(object sender, EventArgs e)
        {
            ConnectionDatabase(GetDbName(), sender);
        }

        /// <summary>
        /// 开启自动备份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartAutobutton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(backupPathbox.Text))
            {
                MessageBox.Show(@"请选择保存路径");
                return;
            }

            ButtonNo(sender, true);
            TextBoxNo(sender, true);
            var text = StartAutobutton.Text;
            if (text == "开启自动备份")
            {
                if (!ConnectionDatabase(GetDbName(), sender)) return;
                this.textBox1.Text += System.Environment.NewLine + $@"时间:{DateTime.Now:yyyy-MM--dd hh:mm},开启自动备份...";
            }
            else
            {
                this.textBox1.Text += System.Environment.NewLine + $@"时间:{DateTime.Now:yyyy-MM--dd hh:mm},关闭自动备份...:";
            }
            StartAutobutton.Text = text == "关闭自动备份" ? "开启自动备份" : "关闭自动备份";

            try
            {
                StaticForm1 = this;
                IScheduler scheduler = new StdSchedulerFactory().GetScheduler();
                JobDetailImpl jdBossReport = new JobDetailImpl("Backup", typeof(Backups));
                IMutableTrigger trigger = CronScheduleBuilder.DailyAtHourAndMinute(Convert.ToInt16(HourText.Text), Convert.ToInt16(MinuteText.Text)).Build();
                trigger.Key = new TriggerKey("AutoBackups");
                if (StartAutobutton.Text == @"开启自动备份")
                {
                    scheduler.Shutdown();
                    ButtonNo(sender, false);
                    TextBoxNo(sender, false);
                    return;
                }
                scheduler.ScheduleJob(jdBossReport, trigger);
                scheduler.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"未知错误 请重试");
                return;
            }
        }

        /// <summary>
        /// 数据库连接
        /// </summary>
        private bool ConnectionDatabase(List<string> list, object sender)
        {
            if (!list.Any())
            {
                MessageBox.Show(@"请填写正确的数据库名称");
                ButtonNo(sender, false);
                TextBoxNo(sender, false);
                return false;
            }

            foreach (var dbName in list)
            {
                var connectionString = "server=" + serverName.Text.Trim() + ";database=" +
                                       dbName.Trim() + ";uid=" + username.Text.Trim() + ";pwd=" +
                                       password.Text.Trim();
                var conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    this.textBox1.Text += System.Environment.NewLine + $@"数据库[{dbName}]连接成功....";
                }
                catch (Exception exception)
                {
                    MessageBox.Show(@"数据库连接失败   " + exception.Message);
                    ButtonNo(sender, false);
                    TextBoxNo(sender, false);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }

            return true;
        }

        public List<string> GetDbName()
        {
            var list = new List<string>();
            if (!string.IsNullOrEmpty(databaseName.Text) && !string.IsNullOrWhiteSpace(databaseName.Text)) list.Add(databaseName.Text);
            if (!string.IsNullOrEmpty(databaseName2.Text) && !string.IsNullOrWhiteSpace(databaseName2.Text)) list.Add(databaseName2.Text);
            if (!string.IsNullOrEmpty(databaseName3.Text) && !string.IsNullOrWhiteSpace(databaseName3.Text)) list.Add(databaseName3.Text);
            return list;
        }

        /// <summary>
        ///关闭按钮点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="b"></param>
        public void ButtonNo(object sender, bool b)
        {
            foreach (Control ctr in Controls)
            {
                if (ctr.GetType().FullName == "System.Windows.Forms.Button")
                {
                    if (ctr.Name != ((Control)sender).Name && b)
                    {
                        ctr.Enabled = false;
                    }
                    else
                    {
                        ctr.Enabled = true;
                    }
                }
            }
        }

        /// <summary>
        ///关闭输入框编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="b"></param>
        public void TextBoxNo(object sender, bool b)
        {
            foreach (Control ctr in Controls)
            {
                if (ctr.GetType().FullName == "System.Windows.Forms.TextBox")
                {
                    if (ctr.Name != ((Control)sender).Name && b)
                    {
                        ctr.Enabled = false;
                    }
                    else
                    {
                        ctr.Enabled = true;
                    }
                }
            }
        }

        /// <summary>
        ///保存路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                Description = @"请选择保存路径",
                SelectedPath = Application.StartupPath
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                backupPathbox.Text = dialog.SelectedPath;
            }
        }

        /// <summary>
        ///小时输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HourText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        ///分钟输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinuteText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void backupPathbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}