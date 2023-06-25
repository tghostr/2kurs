using _2kurs0.Controls;
using Google.Protobuf.WellKnownTypes;
using kursproga;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;
using DGVPrinterHelper;
using System.ComponentModel.Design;
using System.Reflection;

namespace _2kurs0
{
    public partial class MainForm : Form
    {
        private btMenu currentBtn;
        bool sidebarExpand;

        Edit form;
        //long idStaff = Convert.ToInt64(Global.GlobalVar);
        public MainForm()
        {
            InitializeComponent();
            sidebar.Controls.Add(sidePanel);
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            sidePanel.BringToFront();

            form = new Edit(this);
            ActivateButton(btMenuEquip);

            if (Global.GlobalPerms == "1")
            {
                
                btMenuEquip.Visible = false;
                btMenuMaterial.Visible = false;
                btMenuStaff.Visible = false;
                btMenuAuth.Visible = false;
                btMenuRequest.Visible = false;
                btMenuNewRequest.Location = new Point(0, 73);
                TabControl.SelectedTab = NewRequestPage;
                lblTab.Text = btMenuNewRequest.TabName;

                /*EquipPage.Parent = null;
                MaterialPage.Parent = null;
                StaffPage.Parent = null;
                AuthorizationPage.Parent = null;
                RequestPage.Parent = null;*/
            }
        }





        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (btMenu)senderBtn;
                MoveSidePanel(currentBtn);
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(41, 41, 49);
            }
        }
        public void addColumns(DataGridView dgv)
        {
            DataGridViewButtonColumn editBtColumn = new DataGridViewButtonColumn();
            editBtColumn.Name = "Edit";
            editBtColumn.HeaderText = string.Empty;
            editBtColumn.Text = "Изменить";
            editBtColumn.Width = 80;
            editBtColumn.DefaultCellStyle.BackColor = Color.LightBlue;
            editBtColumn.UseColumnTextForButtonValue = true;
            editBtColumn.FlatStyle = FlatStyle.Flat;

            int columnEIndex = 6;
            if (dgv.Columns["Edit"] == null)
            {
                dgv.Columns.Insert(columnEIndex, editBtColumn);
            }
            DataGridViewButtonColumn deleteBtColumn = new DataGridViewButtonColumn();
            deleteBtColumn.Name = "Delete";
            deleteBtColumn.HeaderText = string.Empty;
            deleteBtColumn.Text = "Удалить";
            deleteBtColumn.Width = 80;
            deleteBtColumn.DefaultCellStyle.BackColor = Color.LightCoral;
            deleteBtColumn.UseColumnTextForButtonValue = true;
            deleteBtColumn.FlatStyle = FlatStyle.Flat;
            int columnDIndex = 7;
            if (dgv.Columns["Delete"] == null)
            {
                dgv.Columns.Insert(columnDIndex, deleteBtColumn);
            }
        }
        public void adddeleteColumns(DataGridView dgv, int colindex)
        {
            DataGridViewButtonColumn deleteBtColumn = new DataGridViewButtonColumn();
            deleteBtColumn.Name = "Delete";
            deleteBtColumn.HeaderText = string.Empty;
            deleteBtColumn.Text = "Удалить";
            deleteBtColumn.Width = 80;
            deleteBtColumn.DefaultCellStyle.BackColor = Color.LightCoral;
            deleteBtColumn.UseColumnTextForButtonValue = true;
            deleteBtColumn.FlatStyle = FlatStyle.Flat;
            int columnDIndex = colindex;
            if (dgv.Columns["Delete"] == null)
            {
                dgv.Columns.Insert(columnDIndex, deleteBtColumn);
            }
        }
        #region SideBar
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        private void btMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        private void MoveSidePanel(Control c)
        {
            sidePanel.Visible = true;
            sidePanel.Height = c.Height;
            sidePanel.Top = c.Top;
        }
        #endregion
        #region BUTTONS
        private void btMenuEquip_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //MoveSidePanel(btMenuEquip);
            TabControl.SelectedTab = EquipPage;
            lblTab.Text = btMenuEquip.TabName;
        }

        private void btMenuMaterial_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            TabControl.SelectedTab = MaterialPage;
            lblTab.Text = btMenuMaterial.TabName;
        }

        private void btMenuStaff_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            TabControl.SelectedTab = StaffPage;
            lblTab.Text = btMenuStaff.TabName;
        }

        private void btMenuAuth_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            TabControl.SelectedTab = AuthorizationPage;
            lblTab.Text = btMenuAuth.TabName;
        }

        private void btMenuRequest_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            TabControl.SelectedTab = RequestPage;
            lblTab.Text = btMenuRequest.TabName;
        }
        private void btMenuNewRequest_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            TabControl.SelectedTab = NewRequestPage;
            lblTab.Text = btMenuNewRequest.TabName;
        }
        private void btMenuProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            TabControl.SelectedTab = ProfilePage;
            lblTab.Text = btMenuProfile.TabName;
        }
        private void btMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthForm authForm = new AuthForm();
            authForm.Show();
        }
        #endregion
        #region TOP PANEL
        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btMax.Visible = false;
            btMin.Location = btMax.Location;
            btMin.Visible = true;
            TabControl.Size = TabControl.MaximumSize;
            MoveSidePanel(currentBtn);
            dgvEqNewReq.Width = 831;
            dgvMaNewReq.Width = 831;
            dgvNewRequest.Width = 831;
            dgvNewRequest.Location = new Point(968, 100);
            button1.Location = new Point(857, 150);
            button3.Location = new Point(1809, 150);
            button2.Location = new Point(1809, 195);
        }
        private void btMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btMin.Visible = false;
            btMax.Visible = true;
            TabControl.Size = TabControl.MinimumSize;
            MoveSidePanel(currentBtn);
            dgvEqNewReq.Width = 350;
            dgvMaNewReq.Width = 350;
            dgvNewRequest.Width = 350;
            dgvNewRequest.Location = new Point(426, 100);
            button1.Location = new Point(376, 150);
            button3.Location = new Point(781, 150);
            button2.Location = new Point(781, 195);
        }
        private void btTray_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if(btMax.Visible == false)
            {
                btMin_Click(sender, e);
            }
            topPanel.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
        private void lblLogin_Click(object sender, EventArgs e)
        {
            ActivateButton(btMenuProfile);
            TabControl.SelectedTab = ProfilePage;
            lblTab.Text = btMenuProfile.TabName;
        }
        #endregion
        public void ReqFILL()
        {
            DB dbR = new DB();
            DataTable tableR = new DataTable();
            MySqlDataAdapter adapterR = new MySqlDataAdapter();
            MySqlCommand commandR = new MySqlCommand("SELECT request.idrequest, staff.name, staff.surname, request.reqdata, equipment.emname, material.maname, request.reqnumber FROM `ISPr23-35_TazetdinovRR_kurs`.request LEFT OUTER JOIN equipment ON request.equipment_idequipment = equipment.idequipment LEFT OUTER JOIN material ON request.material_idmaterial = material.idmaterial LEFT OUTER JOIN staff ON request.staff_idStaff = staff.idStaff", dbR.getConnection());
            adapterR.SelectCommand = commandR;
            adapterR.Fill(tableR);
            dgvRequest.DataSource = tableR;

            dgvRequest.Columns[0].HeaderText = "#";
            dgvRequest.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRequest.Columns[0].FillWeight = 35;
            dgvRequest.Columns[0].ReadOnly = true;
            dgvRequest.Columns[1].HeaderText = "Имя";
            dgvRequest.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRequest.Columns[1].FillWeight = 100;
            dgvRequest.Columns[2].HeaderText = "Фамилия";
            dgvRequest.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRequest.Columns[2].FillWeight = 100;
            dgvRequest.Columns[3].HeaderText = "Дата создания";
            dgvRequest.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRequest.Columns[3].FillWeight = 85;
            dgvRequest.Columns[4].HeaderText = "Код Оборудования";
            dgvRequest.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRequest.Columns[4].FillWeight = 90;
            dgvRequest.Columns[5].HeaderText = "Код Материала";
            dgvRequest.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRequest.Columns[5].FillWeight = 90;
            dgvRequest.Columns[6].HeaderText = "Количество";
            dgvRequest.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRequest.Columns[6].FillWeight = 100;
            adddeleteColumns(dgvRequest, 7);
        }
        public void MyReq()
        {
            DB dbMyR = new DB();
            DataTable tableMyR = new DataTable();
            MySqlDataAdapter adapterMyR = new MySqlDataAdapter();
            MySqlCommand commandMyR = new MySqlCommand("SELECT request.idrequest, request.reqdata, equipment.emname, material.maname, request.reqnumber FROM `ISPr23-35_TazetdinovRR_kurs`.request LEFT OUTER JOIN equipment ON request.equipment_idequipment = equipment.idequipment LEFT OUTER JOIN material ON request.material_idmaterial = material.idmaterial where `staff_idStaff` = @Sid", dbMyR.getConnection());
            commandMyR.Parameters.Add("@Sid", MySqlDbType.VarChar).Value = Global.GlobalVar;
            adapterMyR.SelectCommand = commandMyR;
            adapterMyR.Fill(tableMyR);
            dgvMyReq.DataSource = tableMyR;

            dgvMyReq.Columns[0].HeaderText = "#";
            dgvMyReq.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvMyReq.Columns[0].FillWeight = 35;
            dgvMyReq.Columns[1].HeaderText = "Дата создания";
            dgvMyReq.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvMyReq.Columns[1].FillWeight = 85;
            dgvMyReq.Columns[2].HeaderText = "Оборудование";
            dgvMyReq.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvMyReq.Columns[2].FillWeight = 75;
            dgvMyReq.Columns[3].HeaderText = "Материал";
            dgvMyReq.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvMyReq.Columns[3].FillWeight = 85;
            dgvMyReq.Columns[4].HeaderText = "Количество";
            dgvMyReq.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvMyReq.Columns[4].FillWeight = 100;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            //Global.GlobalVar = "1";
            ReqFILL();
            MyReq();
            #region Equipment FILL
            DB dbE = new DB();
            DataTable tableE = new DataTable();
            MySqlDataAdapter adapterE = new MySqlDataAdapter();
            MySqlCommand commandE = new MySqlCommand("Select * from `equipment`", dbE.getConnection());
            adapterE.SelectCommand = commandE;
            adapterE.Fill(tableE);
            dgvEquip.DataSource = tableE;

            dgvEquip.Columns[0].HeaderText = "#";
            dgvEquip.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEquip.Columns[0].FillWeight = 40;
            dgvEquip.Columns[0].ReadOnly = true;
            dgvEquip.Columns[1].HeaderText = "Название";
            dgvEquip.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEquip.Columns[1].FillWeight = 200;
            dgvEquip.Columns[2].HeaderText = "Ед. изм.";
            dgvEquip.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEquip.Columns[2].FillWeight = 100;
            dgvEquip.Columns[3].HeaderText = "Цена";
            dgvEquip.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEquip.Columns[3].FillWeight = 100;
            dgvEquip.Columns[4].HeaderText = "Количество";
            dgvEquip.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEquip.Columns[4].FillWeight = 100;
            dgvEquip.Columns[5].HeaderText = "Стоимость";
            dgvEquip.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEquip.Columns[5].FillWeight = 100;
            addColumns(dgvEquip);


            #endregion
            #region Material FILL
            DB dbM = new DB();
            DataTable tableM = new DataTable();
            MySqlDataAdapter adapterM = new MySqlDataAdapter();
            MySqlCommand commandM = new MySqlCommand("Select * from `material`", dbM.getConnection());
            adapterM.SelectCommand = commandM;
            adapterM.Fill(tableM);
            dgvMaterial.DataSource = tableM;

            dgvMaterial.Columns[0].HeaderText = "#";
            dgvMaterial.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMaterial.Columns[0].FillWeight = 40;
            dgvMaterial.Columns[0].ReadOnly = true;
            dgvMaterial.Columns[1].HeaderText = "Название";
            dgvMaterial.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMaterial.Columns[1].FillWeight = 200;
            dgvMaterial.Columns[2].HeaderText = "Ед. изм.";
            dgvMaterial.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMaterial.Columns[2].FillWeight = 100;
            dgvMaterial.Columns[3].HeaderText = "Цена";
            dgvMaterial.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMaterial.Columns[3].FillWeight = 100;
            dgvMaterial.Columns[4].HeaderText = "Количество";
            dgvMaterial.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMaterial.Columns[4].FillWeight = 100;
            dgvMaterial.Columns[5].HeaderText = "Стоимость";
            dgvMaterial.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMaterial.Columns[5].FillWeight = 100;
            addColumns(dgvMaterial);
            #endregion
            #region Staff FILL
            DB dbS = new DB();
            DataTable tableS = new DataTable();
            MySqlDataAdapter adapterS = new MySqlDataAdapter();
            MySqlCommand commandS = new MySqlCommand("Select * from `staff`", dbS.getConnection());
            adapterS.SelectCommand = commandS;
            adapterS.Fill(tableS);

            dgvStaff.DataSource = tableS;

            dgvStaff.Columns[0].HeaderText = "#";
            dgvStaff.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvStaff.Columns[0].FillWeight = 35;
            dgvStaff.Columns[0].ReadOnly = true;
            dgvStaff.Columns[1].HeaderText = "Имя";
            dgvStaff.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvStaff.Columns[1].FillWeight = 220;
            dgvStaff.Columns[2].HeaderText = "Фамилия";
            dgvStaff.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvStaff.Columns[2].FillWeight = 85;
            dgvStaff.Columns[3].HeaderText = "Дата Рождения";
            dgvStaff.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvStaff.Columns[3].FillWeight = 75;
            adddeleteColumns(dgvStaff, 4);
            #endregion
            #region Auth FILL
            DB dbA = new DB();
            DataTable tableA = new DataTable();
            MySqlDataAdapter adapterA = new MySqlDataAdapter();
            MySqlCommand commandA = new MySqlCommand("SELECT idAuthorization, staff.name, staff.surname, login, pass, perms, confirm FROM `ISPr23-35_TazetdinovRR_kurs`.authorization LEFT OUTER JOIN staff ON authorization.idstaff = staff.idStaff", dbA.getConnection());
            adapterA.SelectCommand = commandA;
            adapterA.Fill(tableA);
            dgvAuth.DataSource = tableA;

            dgvAuth.Columns[0].HeaderText = "#";
            dgvAuth.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAuth.Columns[0].FillWeight = 35;
            dgvAuth.Columns[0].ReadOnly = true;
            dgvAuth.Columns[1].HeaderText = "Имя";
            dgvAuth.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAuth.Columns[1].FillWeight = 100;
            dgvAuth.Columns[2].HeaderText = "Фамилия";
            dgvAuth.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAuth.Columns[2].FillWeight = 100;
            dgvAuth.Columns[3].HeaderText = "Логин";
            dgvAuth.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAuth.Columns[3].FillWeight = 100;
            dgvAuth.Columns[4].HeaderText = "Пароль";
            dgvAuth.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAuth.Columns[4].FillWeight = 150;
            dgvAuth.Columns[5].HeaderText = "Уровень доступа";
            dgvAuth.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAuth.Columns[5].FillWeight = 100;
            dgvAuth.Columns[6].HeaderText = "Подтверждение";
            dgvAuth.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAuth.Columns[6].FillWeight = 25;
            #endregion
            #region MyRequest FILL

            

            #endregion
            #region NR FILL
            DB dbER = new DB();
            DataTable tableER = new DataTable();
            MySqlDataAdapter adapterER = new MySqlDataAdapter();
            MySqlCommand commandER = new MySqlCommand("Select `idequipment`, `emname`, `emunit`, `emnumber` from `equipment`", dbER.getConnection());
            adapterER.SelectCommand = commandER;
            adapterER.Fill(tableER);
            dgvEqNewReq.DataSource = tableER;

            dgvEqNewReq.Columns[0].HeaderText = "#";
            dgvEqNewReq.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEqNewReq.Columns[0].FillWeight = 40;
            dgvEqNewReq.Columns[1].HeaderText = "Название";
            dgvEqNewReq.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEqNewReq.Columns[1].FillWeight = 150;
            dgvEqNewReq.Columns[2].HeaderText = "Ед. изм.";
            dgvEqNewReq.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEqNewReq.Columns[2].FillWeight = 80;
            dgvEqNewReq.Columns[3].HeaderText = "Количество";
            dgvEqNewReq.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEqNewReq.Columns[3].FillWeight = 80;

            DB dbMR = new DB();
            DataTable tableMR = new DataTable();
            MySqlDataAdapter adapterMR = new MySqlDataAdapter();
            MySqlCommand commandMR = new MySqlCommand("Select `idmaterial`, `maname`, `maunit`, `manumber` from `material`", dbMR.getConnection());
            adapterMR.SelectCommand = commandMR;
            adapterMR.Fill(tableMR);
            dgvMaNewReq.DataSource = tableMR;

            dgvMaNewReq.Columns[0].HeaderText = "#";
            dgvMaNewReq.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMaNewReq.Columns[0].FillWeight = 40;
            dgvMaNewReq.Columns[1].HeaderText = "Название";
            dgvMaNewReq.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMaNewReq.Columns[1].FillWeight = 150;
            dgvMaNewReq.Columns[2].HeaderText = "Ед. изм.";
            dgvMaNewReq.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMaNewReq.Columns[2].FillWeight = 80;
            dgvMaNewReq.Columns[3].HeaderText = "Количество";
            dgvMaNewReq.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMaNewReq.Columns[3].FillWeight = 80;
            #endregion

            #region Account Info
            DB dbLog = new DB();
            DataTable tableLog = new DataTable();
            MySqlDataAdapter adapterLog = new MySqlDataAdapter();
            MySqlCommand commandLog = new MySqlCommand("Select `login` from `authorization` where `idstaff` = @idstaff", dbLog.getConnection());
            commandLog.Parameters.Add("@idstaff", MySqlDbType.VarChar).Value = Global.GlobalVar;
            adapterLog.SelectCommand = commandLog;
            adapterLog.Fill(tableLog);
            dbLog.openConnection();
            if (tableLog.Rows.Count > 0)
            {
                lblLogin.Text = commandLog.ExecuteScalar().ToString();
            }
            else
            {
                return;
            }
            dbLog.closeConnection();

            DB dbNS = new DB();
            DataTable tableNS = new DataTable();
            MySqlDataAdapter adapterNS = new MySqlDataAdapter();
            MySqlCommand commandNS = new MySqlCommand("Select `name`, `surname`, `birthdate` from `staff` where `idStaff` = @idStaff", dbNS.getConnection());
            commandNS.Parameters.Add("@idStaff", MySqlDbType.VarChar).Value = Global.GlobalVar;
            adapterNS.SelectCommand = commandNS;
            adapterNS.Fill(tableNS);
            dbNS.openConnection();
            if (tableNS.Rows.Count > 0)
            {
                MySqlDataReader readerNS = commandNS.ExecuteReader();
                //lblNameP.Text = readerNS.GetValue(0).ToString();
                //lblSurnameP.Text = readerNS.GetValue(1).ToString();
                while (readerNS.Read())
                {
                    lblNameP.Text = readerNS.GetValue(0).ToString();
                    lblSurnameP.Text = readerNS.GetValue(1).ToString();
                    BirthDateP.Text = readerNS.GetValue(2).ToString();
                }
            }
            else
            {
                return;
            }
            dbNS.closeConnection();
            #endregion
        }
        #region Display
        public void DisplayE()
        {
            EditEquipment.DisplayAndSearch("SELECT `idequipment`, `emname`, `emunit`, `emprice`, `emnumber`, `emcost` FROM `equipment`", dgvEquip);
        }
        public void DisplayM()
        {
            EditMaterial.DisplayAndSearch("SELECT `idmaterial`, `maname`, `maunit`, `maprice`, `manumber`, `macost` FROM `material`", dgvMaterial);
        }
        public void DisplayS()
        {
            EditEquipment.DisplayAndSearch("SELECT `idStaff`, `name`, `surname`, `birthdate` FROM `staff`", dgvStaff);
        }
        public void DisplayA()
        {
            EditEquipment.DisplayAndSearch("SELECT `idAuthorization`, `idstaff`, `login`, `pass`, `perms`, `confirm` FROM `authorization`", dgvAuth);
        }
        public void DisplayR()
        {
            EditEquipment.DisplayAndSearch("SELECT `idrequest`, `staff_idStaff`, `reqdata`, `equipment_idequipment`, `material_idmaterial`, `reqnumber` FROM `request`", dgvRequest);
        }
        #endregion
        private void btAddEquip_Click(object sender, EventArgs e)
        {
            form.GoToTab(0);
            form.Clear();
            form.AddEInfo();
            form.ShowDialog();

        }

        private void btAddMaterial_Click(object sender, EventArgs e)
        {
            form.GoToTab(1);
            form.Clear();
            form.AddMInfo();
            form.ShowDialog();

        }

        private void btAddRequest_Click(object sender, EventArgs e)
        {
            ActivateButton(btMenuNewRequest);
            TabControl.SelectedTab = NewRequestPage;
            lblTab.Text = btMenuNewRequest.TabName;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            DisplayE();
            DisplayM();
        }
        #region Search
        private void tbEquipSearch_TextChanged(object sender, EventArgs e)
        {
            if(tbEquipSearch.Text == "'")
            {
                tbEquipSearch.Text = "";
            }
            EditEquipment.DisplayAndSearch("SELECT * FROM equipment WHERE CONCAT(`idequipment`, `emname`, `emunit`, `emprice`, `emnumber`, `emcost`) like '%" + tbEquipSearch.Text + "%'", dgvEquip);
        }
        private void tbMaterialSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbMaterialSearch.Text == "'")
            {
                tbMaterialSearch.Text = "";
            }
            EditMaterial.DisplayAndSearch("SELECT * FROM material WHERE CONCAT(`idmaterial`, `maname`, `maunit`, `maprice`, `manumber`, `macost`) like '%" + tbMaterialSearch.Text + "%'", dgvMaterial);
        }
        private void tbStaffSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbStaffSearch.Text == "'")
            {
                tbStaffSearch.Text = "";
            }
            EditMaterial.DisplayAndSearch("SELECT * FROM staff WHERE CONCAT(`idStaff`, `name`, `surname`, `birthdate`) like '%" + tbStaffSearch.Text + "%'", dgvStaff);
        }
        private void tbAuthSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbAuthSearch.Text == "'")
            {
                tbAuthSearch.Text = "";
            }
            EditMaterial.DisplayAndSearch("SELECT idAuthorization, staff.name, staff.surname, login, pass, perms, confirm FROM `ISPr23-35_TazetdinovRR_kurs`.authorization LEFT OUTER JOIN staff ON authorization.idstaff = staff.idStaff WHERE CONCAT(idAuthorization, staff.name, staff.surname, login, pass, perms, confirm) like '%" + tbAuthSearch.Text + "%'", dgvAuth);
        }
        private void tbRequestSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbRequestSearch.Text == "'")
            {
                tbRequestSearch.Text = "";
            }
            EditMaterial.DisplayAndSearch("SELECT request.idrequest, staff.name, staff.surname, request.reqdata, equipment.emname, material.maname, request.reqnumber FROM `ISPr23-35_TazetdinovRR_kurs`.request LEFT OUTER JOIN equipment ON request.equipment_idequipment = equipment.idequipment LEFT OUTER JOIN material ON request.material_idmaterial = material.idmaterial LEFT OUTER JOIN staff ON request.staff_idStaff = staff.idStaff WHERE concat_ws(idrequest, name, surname, reqdata, emname, maname, reqnumber) like '%" + tbRequestSearch.Text + "%'", dgvRequest);
        }
        private void tbSearchEM_TextChanged(object sender, EventArgs e)
        {
            if (cbRequestOption.SelectedItem == "Оборудование")
            {
                EditEquipment.DisplayAndSearch("SELECT `idequipment`, `emname`, `emunit`, `emnumber` FROM equipment WHERE CONCAT(`idequipment`, `emname`, `emunit`, `emnumber`) like '%" + tbSearchEM.Text + "%'", dgvEqNewReq);
            }
            if (cbRequestOption.SelectedItem == "Материалы")
            {
                EditMaterial.DisplayAndSearch("SELECT `idmaterial`, `maname`, `maunit`, `manumber` FROM material WHERE CONCAT(`idmaterial`, `maname`, `maunit`, `manumber`) like '%" + tbSearchEM.Text + "%'", dgvMaNewReq);
            }
        }
        #endregion
        private void dgvEquip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form.Clear();
                form.idE = dgvEquip.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.nameE = dgvEquip.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.unitE = dgvEquip.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.priceE = dgvEquip.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.numberE = dgvEquip.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.UpdateEInfo();
                form.ShowDialog();

                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить это оборудование", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    EditEquipment.DeleteEquipment(dgvEquip.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DisplayE();
                }
                return;
            }
        }

        private void dgvMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form.GoToTab(1);
                form.Clear();
                form.idM = dgvMaterial.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.nameM = dgvMaterial.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.unitM = dgvMaterial.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.priceM = dgvMaterial.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.numberM = dgvMaterial.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.UpdateMInfo();
                form.ShowDialog();

                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить этот материал", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    EditMaterial.DeleteMaterial(dgvMaterial.Rows[e.RowIndex].Cells[2].Value.ToString());
                    DisplayM();
                }
                return;
            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить этого пользователя", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DB dbSD = new DB();
                    MySqlCommand commandSD = new MySqlCommand("DELETE FROM `authorization` WHERE `idstaff` = @id", dbSD.getConnection());
                    commandSD.Parameters.Add("@id", MySqlDbType.VarChar).Value = dgvStaff.Rows[e.RowIndex].Cells[1].Value.ToString();
                    dbSD.openConnection();
                    try
                    {
                        commandSD.ExecuteNonQuery();

                        DB dbSAD = new DB();
                        MySqlCommand commandSAD = new MySqlCommand("DELETE FROM `staff` WHERE `idStaff` = @id", dbSAD.getConnection());
                        commandSAD.Parameters.Add("@id", MySqlDbType.VarChar).Value = dgvStaff.Rows[e.RowIndex].Cells[1].Value.ToString();
                        dbSAD.openConnection();
                        try
                        {
                            commandSAD.ExecuteNonQuery();
                            MessageBox.Show("Пользователь удален", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Пользователь не удален \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        dbSAD.closeConnection();

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Пользователь не удален \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dbSD.closeConnection();
                    DisplayA();
                    DisplayS();
                }
                return;
            }
        }
        private void dgvRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить эту заявку", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    
                    DB db = new DB();
                    MySqlCommand commandMD = new MySqlCommand("DELETE FROM `request` WHERE `idrequest` = @Rid", db.getConnection());
                    commandMD.Parameters.Add("@Rid", MySqlDbType.VarChar).Value = dgvRequest.Rows[e.RowIndex].Cells[1].Value.ToString();
                    db.openConnection();
                    try
                    {
                        commandMD.ExecuteNonQuery();
                        MessageBox.Show("Заявка удалена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Заявка не удалена \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    db.closeConnection();
                    DisplayR();
                }
                return;
            }
        }
        private void btConfirmAuth_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Подтвердить пользователя?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string Aid = dgvAuth.CurrentRow.Cells[0].Value.ToString();

                //string id = dgvAuth.Rows[].Cells[2].Value.ToString();

                DB db = new DB();
                MySqlCommand commandEA = new MySqlCommand("UPDATE `authorization` SET `confirm` = @Aconfirm WHERE `idAuthorization` = @Aid;", db.getConnection());
                commandEA.Parameters.Add("@Aid", MySqlDbType.VarChar).Value = Aid;
                commandEA.Parameters.Add("@Aconfirm", MySqlDbType.VarChar).Value = 1;
                db.openConnection();
                try
                {
                    commandEA.ExecuteNonQuery();
                    MessageBox.Show("Пользователь подтвержден", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Пользователь не подтвержден \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.closeConnection();

                DisplayA();
            }
            return;
        }
        private void btDeleteStaff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить пользователя?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string Aid = dgvAuth.CurrentRow.Cells[0].Value.ToString();

                //string id = dgvAuth.Rows[].Cells[2].Value.ToString();

                DB db = new DB();
                MySqlCommand commandEA = new MySqlCommand("UPDATE `authorization` SET `confirm` = @Aconfirm WHERE `idAuthorization` = @Aid;", db.getConnection());
                commandEA.Parameters.Add("@Aid", MySqlDbType.VarChar).Value = Aid;
                commandEA.Parameters.Add("@Aconfirm", MySqlDbType.VarChar).Value = 1;
                db.openConnection();
                try
                {
                    commandEA.ExecuteNonQuery();
                    MessageBox.Show("Пользователь подтвержден", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Пользователь не подтвержден \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.closeConnection();

                DisplayA();
                DisplayS();
            }
            return;
        }
        private void NewPassConfirm_Click(object sender, EventArgs e)
        {
            if (tbAPass.Text.Equals("") || tbNPass.Text.Equals(""))
            {
                MessageBox.Show("Заполните все поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbNPass.Text.Length < 6)
            {
                MessageBox.Show("Новый пароль должен содержать не менее 6 символов!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                var passUser = Hash.hashPassword(tbAPass.Text);
                MySqlCommand command = new MySqlCommand("Select `pass` from `authorization` where `idstaff` = @ID AND `pass` = @AP", db.getConnection());
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;
                command.Parameters.Add("@AP", MySqlDbType.VarChar).Value = passUser;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                db.openConnection();
                if (table.Rows.Count > 0)
                {
                    var newpass = Hash.hashPassword(tbNPass.Text);
                    DB dbNP = new DB();
                    MySqlCommand commandNP = new MySqlCommand("UPDATE `authorization` SET `pass` = @NP WHERE `idstaff` = @ID;", dbNP.getConnection());
                    commandNP.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;
                    commandNP.Parameters.Add("@NP", MySqlDbType.VarChar).Value = newpass;
                    dbNP.openConnection();
                    try
                    {
                        commandNP.ExecuteNonQuery();
                        MessageBox.Show("Пароль обновлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Пароль не обновлен \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dbNP.closeConnection();
                }
                else
                {
                    MessageBox.Show("Неправильный пароль!");
                }
                db.closeConnection();
            }
        }

        private void cbRequestOption_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index > -1)
                e.Graphics.DrawString(cbRequestOption.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

        private void cbRequestOption_TextChanged(object sender, EventArgs e)
        {
            if (cbRequestOption.Text == "Оборудование")
            {
                dgvMaNewReq.Visible = false;
                dgvEqNewReq.Visible = true;
            }
            if (cbRequestOption.Text == "Материалы")
            {
                dgvEqNewReq.Visible = false;
                dgvMaNewReq.Visible = true;
            }
        }

        private void cbRequestOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRequestOption.SelectedItem == "Оборудование")
            {
                dgvMaNewReq.Visible = false;
                dgvEqNewReq.Visible = true;
            }
            if (cbRequestOption.SelectedItem == "Материалы")
            {
                dgvEqNewReq.Visible = false;
                dgvMaNewReq.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbRequestOption.Text == "")
            {
                MessageBox.Show("Выберите таблицу ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cbRequestOption.SelectedItem == "Оборудование")
            {
                foreach (DataGridViewRow row in dgvEqNewReq.SelectedRows)
                {
                    object[] items = new object[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count - 1; i++)
                    {
                        items[i] = row.Cells[i].Value;
                    }
                    items[3] = row.Cells[3].Value = 1;
                    dgvNewRequest.Rows.Add(items);
                    // fromDGV.Rows.Delete(row);
                }
            }
            if (cbRequestOption.SelectedItem == "Материалы")
            {
                foreach (DataGridViewRow row in dgvMaNewReq.SelectedRows)
                {
                    object[] items = new object[row.Cells.Count];
                    for (int i = 0; i < row.Cells.Count - 1; i++)
                    {
                        items[i] = row.Cells[i].Value;
                    }
                    items[3] = row.Cells[3].Value = 1;
                    dgvNewRequest.Rows.Add(items);
                    // fromDGV.Rows.Delete(row);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvNewRequest.Rows.Clear();
            dgvNewRequest.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvNewRequest.SelectedRows.Count == 0)
            {
                MessageBox.Show("Нет выбранных строк", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dgvNewRequest.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dgvNewRequest.SelectedRows)
                {
                    dgvNewRequest.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void cbRequestOption_Click(object sender, EventArgs e)
        {
            if (dgvNewRequest.Rows.Count > 0)
            {
                MessageBox.Show("Очистите содержимое таблицы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        private void SaveNewRequest_Click(object sender, EventArgs e)
        {
            if (cbRequestOption.Text == "")
                MessageBox.Show("Выберите таблицу ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            





            DB dbNewR = new DB();
            MySqlCommand commandNewR;
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            if (cbRequestOption.SelectedItem == "Оборудование")
            {
                if (dgvNewRequest.Rows.Count == 0)
                {
                    MessageBox.Show("Выберите оборудованиие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                for (int i = 0; i < dgvNewRequest.Rows.Count; i++)
                {
                    if (dgvNewRequest.Rows[i].Cells[3].Value == null)
                    {
                        dgvNewRequest.Rows[i].Cells[3].Value = 1;
                    }
                    commandNewR = new MySqlCommand("INSERT INTO `request`(`staff_idStaff`, `reqdata`, `equipment_idequipment`, `reqnumber`) VALUES(@ID, @DataRN, @Equipment, @Number)", dbNewR.getConnection());

                    commandNewR.Parameters.Add("@ID", MySqlDbType.Int32).Value = Global.GlobalVar;
                    commandNewR.Parameters.Add("@DataRN", MySqlDbType.VarChar).Value = date;
                    commandNewR.Parameters.Add("@Equipment", MySqlDbType.Int32).Value = dgvNewRequest.Rows[i].Cells[0].Value.ToString();
                    commandNewR.Parameters.Add("@Number", MySqlDbType.Int32).Value = dgvNewRequest.Rows[i].Cells[3].Value.ToString();

                    dbNewR.openConnection();
                    commandNewR.ExecuteNonQuery();
                    dbNewR.closeConnection();
                }
                MessageBox.Show("Заявка добавлена");
            }
            if (cbRequestOption.SelectedItem == "Материалы")
            {
                if (dgvNewRequest.Rows.Count == 0)
                {
                    MessageBox.Show("Выберите материалы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                for (int i = 0; i < dgvNewRequest.Rows.Count; i++)
                {
                    if (dgvNewRequest.Rows[i].Cells[3].Value == null)
                    {
                        dgvNewRequest.Rows[i].Cells[3].Value = 1;
                    }
                    commandNewR = new MySqlCommand("INSERT INTO `request`(`staff_idStaff`, `reqdata`, `material_idmaterial`, `reqnumber`) VALUES(@ID, @DataRN, @Material, @Number)", dbNewR.getConnection());

                    commandNewR.Parameters.Add("@ID", MySqlDbType.Int32).Value = Global.GlobalVar;
                    commandNewR.Parameters.Add("@DataRN", MySqlDbType.VarChar).Value = date;
                    commandNewR.Parameters.Add("@Material", MySqlDbType.Int32).Value = dgvNewRequest.Rows[i].Cells[0].Value.ToString();
                    commandNewR.Parameters.Add("@Number", MySqlDbType.Int32).Value = dgvNewRequest.Rows[i].Cells[3].Value.ToString();

                    dbNewR.openConnection();
                    commandNewR.ExecuteNonQuery();
                    dbNewR.closeConnection();
                }
                MessageBox.Show("Заявка добавлена");
            }
            if (dgvNewRequest.Rows.Count > 0)
            {
                ReqFILL();
                MyReq();
                DateTime datereq = DateTime.Now;
                string formdate = datereq.ToString("yyyy.MM.dd HH:mm:ss");
                DGVPrinter printer = new DGVPrinter();
                printer.Title = ("Заявка " + formdate);
                printer.SubTitle = string.Format("", printer.SubTitleColor = Color.Black, printer);
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = false; // if you need page numbers you can keep this as true other wise false
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "ООО БайТекс"; //this is the footer
                printer.FooterSpacing = 15;
                printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.PrintDataGridView(dgvNewRequest);
            }
        }
    }
}
