namespace _2kurs0
{
    partial class AuthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.btClose = new System.Windows.Forms.Button();
            this.btTray = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.SignUI = new _2kurs0.TabControlWithoutHeader();
            this.SignInPage = new System.Windows.Forms.TabPage();
            this.lblReg = new System.Windows.Forms.Label();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.btSignIn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbPass = new System.Windows.Forms.CheckBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.SignUpPage = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbRegName = new System.Windows.Forms.TextBox();
            this.RegBirth = new System.Windows.Forms.DateTimePicker();
            this.lblLog = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbRegSurname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbRegLog = new System.Windows.Forms.TextBox();
            this.btSignUp = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbRegPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTab = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.SignUI.SuspendLayout();
            this.SignInPage.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SignUpPage.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.Location = new System.Drawing.Point(310, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(40, 30);
            this.btClose.TabIndex = 3;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btTray
            // 
            this.btTray.Dock = System.Windows.Forms.DockStyle.Right;
            this.btTray.FlatAppearance.BorderSize = 0;
            this.btTray.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.btTray.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(70)))), ((int)(((byte)(78)))));
            this.btTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTray.ForeColor = System.Drawing.Color.Black;
            this.btTray.Image = ((System.Drawing.Image)(resources.GetObject("btTray.Image")));
            this.btTray.Location = new System.Drawing.Point(270, 0);
            this.btTray.Name = "btTray";
            this.btTray.Size = new System.Drawing.Size(40, 30);
            this.btTray.TabIndex = 4;
            this.btTray.UseVisualStyleBackColor = true;
            this.btTray.Click += new System.EventHandler(this.btTray_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.topPanel.Controls.Add(this.btTray);
            this.topPanel.Controls.Add(this.btClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(350, 30);
            this.topPanel.TabIndex = 5;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            // 
            // SignUI
            // 
            this.SignUI.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.SignUI.Controls.Add(this.SignInPage);
            this.SignUI.Controls.Add(this.SignUpPage);
            this.SignUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignUI.Location = new System.Drawing.Point(0, 80);
            this.SignUI.Name = "SignUI";
            this.SignUI.SelectedIndex = 0;
            this.SignUI.Size = new System.Drawing.Size(350, 370);
            this.SignUI.TabIndex = 6;
            // 
            // SignInPage
            // 
            this.SignInPage.Controls.Add(this.lblReg);
            this.SignInPage.Controls.Add(this.SearchPanel);
            this.SignInPage.Controls.Add(this.btSignIn);
            this.SignInPage.Controls.Add(this.panel2);
            this.SignInPage.Location = new System.Drawing.Point(4, 4);
            this.SignInPage.Name = "SignInPage";
            this.SignInPage.Padding = new System.Windows.Forms.Padding(3);
            this.SignInPage.Size = new System.Drawing.Size(342, 342);
            this.SignInPage.TabIndex = 0;
            this.SignInPage.Text = "Login";
            this.SignInPage.UseVisualStyleBackColor = true;
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.lblReg.Location = new System.Drawing.Point(110, 250);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(121, 16);
            this.lblReg.TabIndex = 11;
            this.lblReg.Text = "Создать аккаунт";
            this.lblReg.Click += new System.EventHandler(this.lblReg_Click);
            this.lblReg.MouseEnter += new System.EventHandler(this.lblLog_MouseEnter);
            this.lblReg.MouseLeave += new System.EventHandler(this.lblLog_MouseLeave);
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPanel.Controls.Add(this.tbLogin);
            this.SearchPanel.ForeColor = System.Drawing.Color.White;
            this.SearchPanel.Location = new System.Drawing.Point(71, 80);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(200, 40);
            this.SearchPanel.TabIndex = 8;
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogin.BackColor = System.Drawing.SystemColors.Window;
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbLogin.Location = new System.Drawing.Point(10, 11);
            this.tbLogin.MaxLength = 20;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.PlaceholderText = "Логин";
            this.tbLogin.Size = new System.Drawing.Size(150, 16);
            this.tbLogin.TabIndex = 6;
            // 
            // btSignIn
            // 
            this.btSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.btSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSignIn.FlatAppearance.BorderSize = 0;
            this.btSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSignIn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSignIn.ForeColor = System.Drawing.Color.White;
            this.btSignIn.Location = new System.Drawing.Point(71, 200);
            this.btSignIn.MaximumSize = new System.Drawing.Size(200, 40);
            this.btSignIn.MinimumSize = new System.Drawing.Size(200, 40);
            this.btSignIn.Name = "btSignIn";
            this.btSignIn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btSignIn.Size = new System.Drawing.Size(200, 40);
            this.btSignIn.TabIndex = 10;
            this.btSignIn.Text = "Войти";
            this.btSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSignIn.UseVisualStyleBackColor = false;
            this.btSignIn.Click += new System.EventHandler(this.btSignIn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbPass);
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(71, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 40);
            this.panel2.TabIndex = 9;
            // 
            // cbPass
            // 
            this.cbPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPass.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbPass.Location = new System.Drawing.Point(159, -1);
            this.cbPass.Name = "cbPass";
            this.cbPass.Size = new System.Drawing.Size(40, 40);
            this.cbPass.TabIndex = 12;
            this.cbPass.UseVisualStyleBackColor = true;
            this.cbPass.CheckedChanged += new System.EventHandler(this.cbPass_CheckedChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.BackColor = System.Drawing.SystemColors.Window;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPassword.Location = new System.Drawing.Point(10, 11);
            this.tbPassword.MaxLength = 20;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PlaceholderText = "Пароль";
            this.tbPassword.Size = new System.Drawing.Size(150, 16);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // SignUpPage
            // 
            this.SignUpPage.Controls.Add(this.panel6);
            this.SignUpPage.Controls.Add(this.RegBirth);
            this.SignUpPage.Controls.Add(this.lblLog);
            this.SignUpPage.Controls.Add(this.panel5);
            this.SignUpPage.Controls.Add(this.panel3);
            this.SignUpPage.Controls.Add(this.btSignUp);
            this.SignUpPage.Controls.Add(this.panel4);
            this.SignUpPage.Location = new System.Drawing.Point(4, 4);
            this.SignUpPage.Name = "SignUpPage";
            this.SignUpPage.Padding = new System.Windows.Forms.Padding(3);
            this.SignUpPage.Size = new System.Drawing.Size(342, 342);
            this.SignUpPage.TabIndex = 1;
            this.SignUpPage.Text = "Register";
            this.SignUpPage.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.tbRegName);
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(71, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 40);
            this.panel6.TabIndex = 19;
            // 
            // tbRegName
            // 
            this.tbRegName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegName.BackColor = System.Drawing.SystemColors.Window;
            this.tbRegName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRegName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbRegName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbRegName.Location = new System.Drawing.Point(10, 11);
            this.tbRegName.MaxLength = 20;
            this.tbRegName.Name = "tbRegName";
            this.tbRegName.PlaceholderText = "Имя";
            this.tbRegName.Size = new System.Drawing.Size(169, 16);
            this.tbRegName.TabIndex = 6;
            // 
            // RegBirth
            // 
            this.RegBirth.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegBirth.CalendarMonthBackground = System.Drawing.Color.White;
            this.RegBirth.CalendarTitleBackColor = System.Drawing.Color.White;
            this.RegBirth.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.RegBirth.CustomFormat = "yyyy-MM-dd";
            this.RegBirth.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RegBirth.Location = new System.Drawing.Point(71, 204);
            this.RegBirth.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.RegBirth.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.RegBirth.MinimumSize = new System.Drawing.Size(200, 40);
            this.RegBirth.Name = "RegBirth";
            this.RegBirth.Size = new System.Drawing.Size(200, 40);
            this.RegBirth.TabIndex = 18;
            this.RegBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLog.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.lblLog.Location = new System.Drawing.Point(83, 300);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(175, 16);
            this.lblLog.TabIndex = 15;
            this.lblLog.Text = "У меня уже есть аккаунт";
            this.lblLog.Click += new System.EventHandler(this.lblLog_Click);
            this.lblLog.MouseEnter += new System.EventHandler(this.lblLog_MouseEnter);
            this.lblLog.MouseLeave += new System.EventHandler(this.lblLog_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.tbRegSurname);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(71, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 40);
            this.panel5.TabIndex = 14;
            // 
            // tbRegSurname
            // 
            this.tbRegSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegSurname.BackColor = System.Drawing.SystemColors.Window;
            this.tbRegSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRegSurname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbRegSurname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbRegSurname.Location = new System.Drawing.Point(10, 11);
            this.tbRegSurname.MaxLength = 20;
            this.tbRegSurname.Name = "tbRegSurname";
            this.tbRegSurname.PlaceholderText = "Фамилия";
            this.tbRegSurname.Size = new System.Drawing.Size(171, 16);
            this.tbRegSurname.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tbRegLog);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(71, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 40);
            this.panel3.TabIndex = 11;
            // 
            // tbRegLog
            // 
            this.tbRegLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegLog.BackColor = System.Drawing.SystemColors.Window;
            this.tbRegLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRegLog.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbRegLog.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbRegLog.Location = new System.Drawing.Point(10, 11);
            this.tbRegLog.MaxLength = 20;
            this.tbRegLog.Name = "tbRegLog";
            this.tbRegLog.PlaceholderText = "Логин";
            this.tbRegLog.Size = new System.Drawing.Size(173, 16);
            this.tbRegLog.TabIndex = 6;
            // 
            // btSignUp
            // 
            this.btSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.btSignUp.FlatAppearance.BorderSize = 0;
            this.btSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSignUp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSignUp.ForeColor = System.Drawing.Color.White;
            this.btSignUp.Location = new System.Drawing.Point(71, 250);
            this.btSignUp.MaximumSize = new System.Drawing.Size(200, 40);
            this.btSignUp.MinimumSize = new System.Drawing.Size(200, 40);
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btSignUp.Size = new System.Drawing.Size(200, 40);
            this.btSignUp.TabIndex = 13;
            this.btSignUp.Text = "Зарегистрироваться";
            this.btSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSignUp.UseVisualStyleBackColor = false;
            this.btSignUp.Click += new System.EventHandler(this.btSignUp_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tbRegPass);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(71, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 40);
            this.panel4.TabIndex = 12;
            // 
            // tbRegPass
            // 
            this.tbRegPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegPass.BackColor = System.Drawing.SystemColors.Window;
            this.tbRegPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRegPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbRegPass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbRegPass.Location = new System.Drawing.Point(10, 11);
            this.tbRegPass.MaxLength = 20;
            this.tbRegPass.Name = "tbRegPass";
            this.tbRegPass.PlaceholderText = "Пароль";
            this.tbRegPass.Size = new System.Drawing.Size(173, 16);
            this.tbRegPass.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.lblTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 50);
            this.panel1.TabIndex = 7;
            // 
            // lblTab
            // 
            this.lblTab.AutoEllipsis = true;
            this.lblTab.AutoSize = true;
            this.lblTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTab.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTab.ForeColor = System.Drawing.Color.White;
            this.lblTab.Location = new System.Drawing.Point(20, 13);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(151, 25);
            this.lblTab.TabIndex = 5;
            this.lblTab.Text = "Авторизация";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.SignUI);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.topPanel.ResumeLayout(false);
            this.SignUI.ResumeLayout(false);
            this.SignInPage.ResumeLayout(false);
            this.SignInPage.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.SignUpPage.ResumeLayout(false);
            this.SignUpPage.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btClose;
        private Button btTray;
        private Panel topPanel;
        private System.Windows.Forms.Timer sidebarTimer;
        private TabControlWithoutHeader SignUI;
        private TabPage SignInPage;
        private TabPage SignUpPage;
        private Panel panel1;
        private Label lblTab;
        private Panel panel2;
        private TextBox tbPassword;
        private Panel SearchPanel;
        private TextBox tbLogin;
        private Label lblReg;
        private Button btSignIn;
        private Label lblLog;
        private Panel panel5;
        private TextBox tbRegSurname;
        private Panel panel3;
        private TextBox tbRegLog;
        private Button btSignUp;
        private Panel panel4;
        private TextBox tbRegPass;
        private Panel panel6;
        private TextBox tbRegName;
        private DateTimePicker RegBirth;
        private CheckBox cbPass;
    }
}