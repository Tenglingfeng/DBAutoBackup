using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quartz;

namespace SqlServerAutoBuckups
{
    public class Backups : IJob
    {
        public static SqlServer StaticForm1 = SqlServer.StaticForm1;

        public void Execute(IJobExecutionContext context)
        {
            RunBackup();
        }

        private void RunBackup()
        {
            var list = GetDbName();
            foreach (var dbName in list)
            {
                Backup(dbName);
            }
        }

        public List<string> GetDbName()
        {
            var list = new List<string>();
            if (!string.IsNullOrEmpty(StaticForm1.databaseName.Text) && !string.IsNullOrWhiteSpace(StaticForm1.databaseName.Text)) list.Add(StaticForm1.databaseName.Text);
            if (!string.IsNullOrEmpty(StaticForm1.databaseName2.Text) && !string.IsNullOrWhiteSpace(StaticForm1.databaseName2.Text)) list.Add(StaticForm1.databaseName2.Text);
            if (!string.IsNullOrEmpty(StaticForm1.databaseName3.Text) && !string.IsNullOrWhiteSpace(StaticForm1.databaseName3.Text)) list.Add(StaticForm1.databaseName3.Text);
            return list;
        }

        /// <summary>
        /// 数据库操作
        /// </summary>
        private void Backup(string dbName)
        {
            var connectionString = "server=" + StaticForm1.serverName.Text + ";database=" +
                                      dbName + ";uid=" + StaticForm1.username.Text + ";pwd=" +
                                      StaticForm1.password.Text;
            var fileName = dbName + "_" + DateTime.Now.ToShortDateString().Replace(@"/", "");
            var sql = @"backup database " + dbName + " to disk='" + StaticForm1.backupPathbox.Text + "\\" + fileName + ".bak'";

            using (var conn = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    try
                    {
                        conn.Open();
                        command.Connection = conn;
                        command.CommandType = CommandType.Text;
                        command.CommandText = sql;
                        command.ExecuteNonQuery();
                        StaticForm1.textBox1.Text += System.Environment.NewLine + $@"时间:{DateTime.Now:yyyy-MM--dd HH:mm},备份[{dbName}]成功:";
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(@"备份失败" + e.Message);
                        System.Environment.Exit(0);
                        return;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}