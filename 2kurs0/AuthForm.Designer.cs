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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            btClose = new Button();
            btTray = new Button();
            topPanel = new Panel();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            SignUI = new TabControlWithoutHeader();
            SignInPage = new TabPage();
            lblReg = new Label();
            SearchPanel = new Panel();
            tbLogin = new TextBox();
            btSignIn = new Button();
            panel2 = new Panel();
            cbPass = new CheckBox();
            tbPassword = new TextBox();
            SignUpPage = new TabPage();
            panel6 = new Panel();
            tbRegName = new TextBox();
            RegBirth = new DateTimePicker();
            lblLog = new Label();
            panel5 = new Panel();
            tbRegSurname = new TextBox();
            panel3 = new Panel();
            tbRegLog = new TextBox();
            btSignUp = new Button();
            panel4 = new Panel();
            tbRegPass = new TextBox();
            panel1 = new Panel();
            lblTab = new Label();
            topPanel.SuspendLayout();
            SignUI.SuspendLayout();
            SignInPage.SuspendLayout();
            SearchPanel.SuspendLayout();
            panel2.SuspendLayout();
            SignUpPage.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btClose
            // 
            btClose.Dock = DockStyle.Right;
            btClose.FlatAppearance.BorderSize = 0;
            btClose.FlatAppearance.MouseDownBackColor = Color.Red;
            btClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 77, 77);
            btClose.FlatStyle = FlatStyle.Flat;
            btClose.ForeColor = Color.Black;
            btClose.Image = (Image)resources.GetObject("btClose.Image");
            btClose.Location = new Point(310, 0);
            btClose.Name = "btClose";
            btClose.Size = new Size(40, 30);
            btClose.TabIndex = 3;
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // btTray
            // 
            btTray.Dock = DockStyle.Right;
            btTray.FlatAppearance.BorderSize = 0;
            btTray.FlatAppearance.MouseDownBackColor = Color.FromArgb(79, 81, 89);
            btTray.FlatAppearance.MouseOverBackColor = Color.FromArgb(68, 70, 78);
            btTray.FlatStyle = FlatStyle.Flat;
            btTray.ForeColor = Color.Black;
            btTray.Image = (Image)resources.GetObject("btTray.Image");
            btTray.Location = new Point(270, 0);
            btTray.Name = "btTray";
            btTray.Size = new Size(40, 30);
            btTray.TabIndex = 4;
            btTray.UseVisualStyleBackColor = true;
            btTray.Click += btTray_Click;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(36, 38, 48);
            topPanel.Controls.Add(btTray);
            topPanel.Controls.Add(btClose);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(350, 30);
            topPanel.TabIndex = 5;
            topPanel.MouseDown += topPanel_MouseDown;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            // 
            // SignUI
            // 
            SignUI.Alignment = TabAlignment.Bottom;
            SignUI.Controls.Add(SignInPage);
            SignUI.Controls.Add(SignUpPage);
            SignUI.Dock = DockStyle.Fill;
            SignUI.Location = new Point(0, 80);
            SignUI.Name = "SignUI";
            SignUI.SelectedIndex = 0;
            SignUI.Size = new Size(350, 370);
            SignUI.TabIndex = 6;
            // 
            // SignInPage
            // 
            SignInPage.BackColor = Color.White;
            SignInPage.Controls.Add(lblReg);
            SignInPage.Controls.Add(SearchPanel);
            SignInPage.Controls.Add(btSignIn);
            SignInPage.Controls.Add(panel2);
            SignInPage.Location = new Point(4, 4);
            SignInPage.Name = "SignInPage";
            SignInPage.Padding = new Padding(3);
            SignInPage.Size = new Size(342, 342);
            SignInPage.TabIndex = 0;
            SignInPage.Text = "Login";
            // 
            // lblReg
            // 
            lblReg.AutoSize = true;
            lblReg.Cursor = Cursors.Hand;
            lblReg.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblReg.ForeColor = Color.FromArgb(1, 158, 253);
            lblReg.Location = new Point(110, 250);
            lblReg.Name = "lblReg";
            lblReg.Size = new Size(121, 16);
            lblReg.TabIndex = 11;
            lblReg.Text = "Создать аккаунт";
            lblReg.Click += lblReg_Click;
            lblReg.MouseEnter += lblLog_MouseEnter;
            lblReg.MouseLeave += lblLog_MouseLeave;
            // 
            // SearchPanel
            // 
            SearchPanel.BackColor = Color.Transparent;
            SearchPanel.BorderStyle = BorderStyle.FixedSingle;
            SearchPanel.Controls.Add(tbLogin);
            SearchPanel.ForeColor = Color.White;
            SearchPanel.Location = new Point(71, 80);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(200, 40);
            SearchPanel.TabIndex = 8;
            // 
            // tbLogin
            // 
            tbLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbLogin.BackColor = SystemColors.Window;
            tbLogin.BorderStyle = BorderStyle.None;
            tbLogin.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbLogin.ForeColor = SystemColors.WindowText;
            tbLogin.Location = new Point(10, 11);
            tbLogin.MaxLength = 20;
            tbLogin.Name = "tbLogin";
            tbLogin.PlaceholderText = "Логин";
            tbLogin.Size = new Size(150, 16);
            tbLogin.TabIndex = 6;
            // 
            // btSignIn
            // 
            btSignIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btSignIn.BackColor = Color.FromArgb(1, 158, 253);
            btSignIn.Cursor = Cursors.Hand;
            btSignIn.FlatAppearance.BorderSize = 0;
            btSignIn.FlatStyle = FlatStyle.Flat;
            btSignIn.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btSignIn.ForeColor = Color.White;
            btSignIn.Location = new Point(71, 200);
            btSignIn.MaximumSize = new Size(200, 40);
            btSignIn.MinimumSize = new Size(200, 40);
            btSignIn.Name = "btSignIn";
            btSignIn.Padding = new Padding(5, 0, 0, 0);
            btSignIn.Size = new Size(200, 40);
            btSignIn.TabIndex = 10;
            btSignIn.Text = "Войти";
            btSignIn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSignIn.UseVisualStyleBackColor = false;
            btSignIn.Click += btSignIn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cbPass);
            panel2.Controls.Add(tbPassword);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(71, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 40);
            panel2.TabIndex = 9;
            // 
            // cbPass
            // 
            cbPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbPass.CheckAlign = ContentAlignment.MiddleCenter;
            cbPass.Location = new Point(159, -1);
            cbPass.Name = "cbPass";
            cbPass.Size = new Size(40, 40);
            cbPass.TabIndex = 12;
            cbPass.UseVisualStyleBackColor = true;
            cbPass.CheckedChanged += cbPass_CheckedChanged;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.BackColor = SystemColors.Window;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbPassword.ForeColor = SystemColors.WindowText;
            tbPassword.Location = new Point(10, 11);
            tbPassword.MaxLength = 20;
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Пароль";
            tbPassword.Size = new Size(150, 16);
            tbPassword.TabIndex = 6;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // SignUpPage
            // 
            SignUpPage.BackColor = Color.White;
            SignUpPage.Controls.Add(panel6);
            SignUpPage.Controls.Add(RegBirth);
            SignUpPage.Controls.Add(lblLog);
            SignUpPage.Controls.Add(panel5);
            SignUpPage.Controls.Add(panel3);
            SignUpPage.Controls.Add(btSignUp);
            SignUpPage.Controls.Add(panel4);
            SignUpPage.Location = new Point(4, 4);
            SignUpPage.Name = "SignUpPage";
            SignUpPage.Padding = new Padding(3);
            SignUpPage.Size = new Size(342, 342);
            SignUpPage.TabIndex = 1;
            SignUpPage.Text = "Register";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(tbRegName);
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(71, 20);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 40);
            panel6.TabIndex = 19;
            // 
            // tbRegName
            // 
            tbRegName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbRegName.BackColor = SystemColors.Window;
            tbRegName.BorderStyle = BorderStyle.None;
            tbRegName.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbRegName.ForeColor = SystemColors.WindowText;
            tbRegName.Location = new Point(10, 11);
            tbRegName.MaxLength = 20;
            tbRegName.Name = "tbRegName";
            tbRegName.PlaceholderText = "Имя";
            tbRegName.Size = new Size(169, 16);
            tbRegName.TabIndex = 6;
            // 
            // RegBirth
            // 
            RegBirth.CalendarFont = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RegBirth.CalendarMonthBackground = Color.White;
            RegBirth.CalendarTitleBackColor = Color.White;
            RegBirth.CalendarTrailingForeColor = Color.Black;
            RegBirth.CustomFormat = "yyyy-MM-dd";
            RegBirth.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RegBirth.Format = DateTimePickerFormat.Custom;
            RegBirth.Location = new Point(71, 204);
            RegBirth.MaxDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            RegBirth.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            RegBirth.MinimumSize = new Size(200, 40);
            RegBirth.Name = "RegBirth";
            RegBirth.Size = new Size(200, 40);
            RegBirth.TabIndex = 18;
            RegBirth.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lblLog
            // 
            lblLog.AutoSize = true;
            lblLog.Cursor = Cursors.Hand;
            lblLog.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLog.ForeColor = Color.FromArgb(1, 158, 253);
            lblLog.Location = new Point(83, 300);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(175, 16);
            lblLog.TabIndex = 15;
            lblLog.Text = "У меня уже есть аккаунт";
            lblLog.Click += lblLog_Click;
            lblLog.MouseEnter += lblLog_MouseEnter;
            lblLog.MouseLeave += lblLog_MouseLeave;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(tbRegSurname);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(71, 66);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 40);
            panel5.TabIndex = 14;
            // 
            // tbRegSurname
            // 
            tbRegSurname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbRegSurname.BackColor = SystemColors.Window;
            tbRegSurname.BorderStyle = BorderStyle.None;
            tbRegSurname.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbRegSurname.ForeColor = SystemColors.WindowText;
            tbRegSurname.Location = new Point(10, 11);
            tbRegSurname.MaxLength = 20;
            tbRegSurname.Name = "tbRegSurname";
            tbRegSurname.PlaceholderText = "Фамилия";
            tbRegSurname.Size = new Size(171, 16);
            tbRegSurname.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(tbRegLog);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(71, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 40);
            panel3.TabIndex = 11;
            // 
            // tbRegLog
            // 
            tbRegLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbRegLog.BackColor = SystemColors.Window;
            tbRegLog.BorderStyle = BorderStyle.None;
            tbRegLog.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbRegLog.ForeColor = SystemColors.WindowText;
            tbRegLog.Location = new Point(10, 11);
            tbRegLog.MaxLength = 20;
            tbRegLog.Name = "tbRegLog";
            tbRegLog.PlaceholderText = "Логин";
            tbRegLog.Size = new Size(173, 16);
            tbRegLog.TabIndex = 6;
            // 
            // btSignUp
            // 
            btSignUp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btSignUp.BackColor = Color.FromArgb(1, 158, 253);
            btSignUp.FlatAppearance.BorderSize = 0;
            btSignUp.FlatStyle = FlatStyle.Flat;
            btSignUp.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btSignUp.ForeColor = Color.White;
            btSignUp.Location = new Point(71, 250);
            btSignUp.MaximumSize = new Size(200, 40);
            btSignUp.MinimumSize = new Size(200, 40);
            btSignUp.Name = "btSignUp";
            btSignUp.Padding = new Padding(5, 0, 0, 0);
            btSignUp.Size = new Size(200, 40);
            btSignUp.TabIndex = 13;
            btSignUp.Text = "Зарегистрироваться";
            btSignUp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSignUp.UseVisualStyleBackColor = false;
            btSignUp.Click += btSignUp_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(tbRegPass);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(71, 158);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 40);
            panel4.TabIndex = 12;
            // 
            // tbRegPass
            // 
            tbRegPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbRegPass.BackColor = SystemColors.Window;
            tbRegPass.BorderStyle = BorderStyle.None;
            tbRegPass.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbRegPass.ForeColor = SystemColors.WindowText;
            tbRegPass.Location = new Point(10, 11);
            tbRegPass.MaxLength = 20;
            tbRegPass.Name = "tbRegPass";
            tbRegPass.PlaceholderText = "Пароль";
            tbRegPass.Size = new Size(173, 16);
            tbRegPass.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(69, 70, 79);
            panel1.Controls.Add(lblTab);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 50);
            panel1.TabIndex = 7;
            // 
            // lblTab
            // 
            lblTab.AutoEllipsis = true;
            lblTab.AutoSize = true;
            lblTab.FlatStyle = FlatStyle.Flat;
            lblTab.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTab.ForeColor = Color.White;
            lblTab.Location = new Point(20, 13);
            lblTab.Name = "lblTab";
            lblTab.Size = new Size(151, 25);
            lblTab.TabIndex = 5;
            lblTab.Text = "Авторизация";
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 450);
            Controls.Add(SignUI);
            Controls.Add(panel1);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuthForm";
            topPanel.ResumeLayout(false);
            SignUI.ResumeLayout(false);
            SignInPage.ResumeLayout(false);
            SignInPage.PerformLayout();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            SignUpPage.ResumeLayout(false);
            SignUpPage.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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