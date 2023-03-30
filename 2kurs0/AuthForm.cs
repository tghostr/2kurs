using kursproga;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2kurs0
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }
        #region INTERFACE
        private void lblReg_Click(object sender, EventArgs e)
        {
            SignUI.SelectedTab = SignUpPage;
            lblTab.Text = "Регистрация";
        }

        private void lblLog_Click(object sender, EventArgs e)
        {
            SignUI.SelectedTab = SignInPage;
            lblTab.Text = "Авторизация";
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTray_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            topPanel.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void lblLog_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).Font = new Font("Century Gothic", 9.75f, FontStyle.Bold | FontStyle.Underline);
        }
        private void lblLog_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).Font = new Font("Century Gothic", 9.75f, FontStyle.Bold);
        }
        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked) { tbPassword.UseSystemPasswordChar = false; }
            else { tbPassword.UseSystemPasswordChar = true; }
        }
        #endregion
        private void btSignIn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            var loginUser = tbLogin.Text;
            var passUser = Hash.hashPassword(tbPassword.Text);
            MySqlCommand command = new MySqlCommand("Select `idstaff`, `perms` from `authorization` where `login` = @uL AND `pass` = @uP AND `confirm` = 1", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.openConnection();
            if (table.Rows.Count > 0)
            {
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Global.GlobalVar = reader.GetValue(0).ToString();
                    Global.GlobalPerms = reader.GetValue(1).ToString();
                }
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Неправильный логин/пароль или у вас нет доступа к аккаунту!");
            }
            db.closeConnection();
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            var loginUser = tbRegLog.Text;
            if(tbRegLog.Text.Length < 6 || tbRegPass.Text.Length < 6)
            {
                MessageBox.Show("Пароль должен содержать не менее 6 символов!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbRegName.Text.Equals("") || tbRegSurname.Text.Equals("") || tbRegLog.Text.Equals("") || tbRegPass.Text.Equals(""))
            {
                MessageBox.Show("Заполните все поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (RegBirth.Text.Equals(""))
            {
                MessageBox.Show("Заполните вашу дату рождения!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("Select `idstaff` from `authorization` where `login` = @uL", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.openConnection();
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.closeConnection();
                String DateB = RegBirth.Text;
                DB db1 = new DB();
                DataTable table1 = new DataTable();
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                MySqlCommand command1 = new MySqlCommand("INSERT INTO `staff`(`name`, `surname`, `birthdate`) VALUES('" + tbRegName.Text + "', '" + tbRegSurname.Text + "', @DateB);", db1.getConnection());
                command1.Parameters.Add("@DateB", MySqlDbType.Date).Value = DateB;
                db1.openConnection();
                if (command1.ExecuteNonQuery() == 1)
                {
                    String nameUser = tbRegName.Text;
                    DB db2 = new DB();
                    DataTable table2 = new DataTable();
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter();
                    MySqlCommand command2 = new MySqlCommand("Select `idStaff` from `staff` where `name` = @uN", db2.getConnection());
                    command2.Parameters.Add("@uN", MySqlDbType.VarChar).Value = nameUser;
                    adapter2.SelectCommand = command2;
                    adapter2.Fill(table2);
                    db2.openConnection();
                    if (table2.Rows.Count > 0)
                    {
                        Global.GlobalVar = command2.ExecuteScalar().ToString();
                        DB db3 = new DB();
                        tbRegName.Text = Global.GlobalVar;
                        var passUser = Hash.hashPassword(tbRegPass.Text);
                        DataTable table3 = new DataTable();
                        MySqlCommand command3 = new MySqlCommand("INSERT INTO `authorization`(`idstaff`, `login`, `pass`, `perms`, `confirm`) VALUES(@ID, @uL, @uP, @perm, @confirm);", db3.getConnection());
                        command3.Parameters.Add("@ID", MySqlDbType.Int64).Value = Global.GlobalVar;
                        command3.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                        command3.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
                        command3.Parameters.Add("@perm", MySqlDbType.VarChar).Value = 1;
                        command3.Parameters.Add("@confirm", MySqlDbType.VarChar).Value = 0;
                        db3.openConnection();
                        if (command3.ExecuteNonQuery() == 1)
                            MessageBox.Show("Регистрация прошла успешно", "Успех");
                        else
                            MessageBox.Show("Во время регистрации произошла ошибка В 3");
                        db3.closeConnection();
                    }
                    else
                        MessageBox.Show("В 2");
                    db2.closeConnection();
                }
                else
                    MessageBox.Show("Ошибка");
                db1.closeConnection();
            }
            SignUI.SelectedTab = SignInPage;
        }
    }
}
