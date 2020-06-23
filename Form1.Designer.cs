namespace SqlServerAutoBuckups
{
    partial class SqlServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MinuteText = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.backupPathbox = new System.Windows.Forms.TextBox();
            this.StartAutobutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.HourText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Testconnection = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.serverName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.databaseName2 = new System.Windows.Forms.TextBox();
            this.databaseName3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 53;
            this.label8.Text = "备份路径";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 52;
            this.label7.Text = ":";
            // 
            // MinuteText
            // 
            this.MinuteText.Location = new System.Drawing.Point(238, 235);
            this.MinuteText.MaxLength = 2;
            this.MinuteText.Name = "MinuteText";
            this.MinuteText.Size = new System.Drawing.Size(31, 21);
            this.MinuteText.TabIndex = 51;
            this.MinuteText.Text = "00";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(275, 270);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(67, 27);
            this.SaveBtn.TabIndex = 49;
            this.SaveBtn.Text = "打开";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click_1);
            // 
            // backupPathbox
            // 
            this.backupPathbox.Location = new System.Drawing.Point(98, 274);
            this.backupPathbox.Name = "backupPathbox";
            this.backupPathbox.Size = new System.Drawing.Size(171, 21);
            this.backupPathbox.TabIndex = 50;
            // 
            // StartAutobutton
            // 
            this.StartAutobutton.Location = new System.Drawing.Point(24, 448);
            this.StartAutobutton.Name = "StartAutobutton";
            this.StartAutobutton.Size = new System.Drawing.Size(318, 29);
            this.StartAutobutton.TabIndex = 48;
            this.StartAutobutton.Text = "开启自动备份";
            this.StartAutobutton.UseVisualStyleBackColor = true;
            this.StartAutobutton.Click += new System.EventHandler(this.StartAutobutton_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 47;
            this.label6.Text = "自动备份";
            // 
            // HourText
            // 
            this.HourText.Location = new System.Drawing.Point(184, 235);
            this.HourText.MaxLength = 2;
            this.HourText.Name = "HourText";
            this.HourText.Size = new System.Drawing.Size(31, 21);
            this.HourText.TabIndex = 46;
            this.HourText.Text = "18";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 45;
            this.label5.Text = "每天";
            // 
            // Testconnection
            // 
            this.Testconnection.Location = new System.Drawing.Point(24, 231);
            this.Testconnection.Name = "Testconnection";
            this.Testconnection.Size = new System.Drawing.Size(102, 27);
            this.Testconnection.TabIndex = 44;
            this.Testconnection.Text = "请先测试连接";
            this.Testconnection.UseVisualStyleBackColor = true;
            this.Testconnection.Click += new System.EventHandler(this.Testconnection_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 43;
            this.label4.Text = "数据库";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 42;
            this.label3.Text = "密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 41;
            this.label2.Text = "用户名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 40;
            this.label1.Text = "服务器域名";
            // 
            // databaseName
            // 
            this.databaseName.Location = new System.Drawing.Point(98, 163);
            this.databaseName.Name = "databaseName";
            this.databaseName.Size = new System.Drawing.Size(80, 21);
            this.databaseName.TabIndex = 39;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(98, 122);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(244, 21);
            this.password.TabIndex = 38;
            this.password.Text = "123456";
            this.password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(98, 72);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(244, 21);
            this.username.TabIndex = 37;
            this.username.Text = "sa";
            // 
            // serverName
            // 
            this.serverName.Location = new System.Drawing.Point(98, 28);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(244, 21);
            this.serverName.TabIndex = 36;
            this.serverName.Text = ".";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 303);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 139);
            this.textBox1.TabIndex = 54;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // databaseName2
            // 
            this.databaseName2.Location = new System.Drawing.Point(184, 163);
            this.databaseName2.Name = "databaseName2";
            this.databaseName2.Size = new System.Drawing.Size(77, 21);
            this.databaseName2.TabIndex = 57;
            // 
            // databaseName3
            // 
            this.databaseName3.Location = new System.Drawing.Point(268, 163);
            this.databaseName3.Name = "databaseName3";
            this.databaseName3.Size = new System.Drawing.Size(73, 21);
            this.databaseName3.TabIndex = 58;
            // 
            // SqlServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 501);
            this.Controls.Add(this.databaseName3);
            this.Controls.Add(this.databaseName2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MinuteText);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.backupPathbox);
            this.Controls.Add(this.StartAutobutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HourText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Testconnection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.databaseName);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.serverName);
            this.Name = "SqlServer";
            this.Text = "SqlServer自动备份";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.OpenFileDialog OpenFileDialog;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox MinuteText;
        public System.Windows.Forms.Button SaveBtn;
        public System.Windows.Forms.TextBox backupPathbox;
        public System.Windows.Forms.Button StartAutobutton;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox HourText;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button Testconnection;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox databaseName;
        public System.Windows.Forms.TextBox password;
        public System.Windows.Forms.TextBox username;
        public System.Windows.Forms.TextBox serverName;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox databaseName2;
        public System.Windows.Forms.TextBox databaseName3;
    }
}

