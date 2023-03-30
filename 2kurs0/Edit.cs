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
    public partial class Edit : Form
    {
        private readonly MainForm _parent;
        public string idE, nameE, unitE, priceE, numberE, costE;
        public string idM, nameM, unitM, priceM, numberM, costM;
        public Edit(MainForm parent)
        {
            InitializeComponent();
            _parent = parent;
        }


        public void UpdateEInfo()
        {
            lblTab.Text = "Изменить оборудование";
            btAddE.Text = "Изменить";
            Ename.Text = nameE;
            Eunit.Text = unitE;
            Eprice.Text = priceE;
            Enumber.Text = numberE;
        }
        public void UpdateMInfo()
        {
            lblTab.Text = "Изменить материла";
            btAddM.Text = "Изменить";
            Mname.Text = nameM;
            Munit.Text = unitM;
            Mprice.Text = priceM;
            Mnumber.Text = numberM;
        }
        public void AddEInfo()
        {
            lblTab.Text = "Добавить оборудование";
            btAddE.Text = "Добавить";
        }
        public void AddMInfo()
        {
            lblTab.Text = "Добавить материал";
            btAddM.Text = "Добавить";
        }
        public void Clear()
        {
            Ename.Text = Eunit.Text = Eprice.Text = Enumber.Text = string.Empty;
            Mname.Text = Munit.Text = Mprice.Text = Mnumber.Text = string.Empty;
        }
        #region TAB
        public void GoToTab(int tabIndex)
        {
            editTabs.SelectedIndex = tabIndex;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            topPanel.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
        #endregion
        private void Edit_Load(object sender, EventArgs e)
        {

        }


        private void btAddE_Click(object sender, EventArgs e)
        {
            if(Ename.Text.Trim().Length < 3)
            {
                MessageBox.Show("Заполните название оборудования");
                return;
            }
            if (Eunit.Text.Trim().Length == 0)
            {
                MessageBox.Show("Заполните единицу измерения оборудования");
                return;
            }
            if (Eprice.Text.Trim().Length == 0)
            {
                MessageBox.Show("Заполните цену оборудования");
                return;
            }
            if (Enumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("Заполните количество оборудования");
                return;
            }
            if(btAddE.Text == "Добавить")
            {
                Equipment eqm = new Equipment(Ename.Text.Trim(), Eunit.Text.Trim(), Eprice.Text.Trim(), Enumber.Text.Trim());
                EditEquipment.AddEquipment(eqm);
                Clear();
            }
            if(btAddE.Text == "Изменить")
            {
                Equipment eqm = new Equipment(Ename.Text.Trim(), Eunit.Text.Trim(), Eprice.Text.Trim(), Enumber.Text.Trim());
                EditEquipment.UpdateEquipment(eqm, idE);
            }
            _parent.DisplayE();
        }
        private void btAddM_Click(object sender, EventArgs e)
        {
            if (Mname.Text.Trim().Length < 3)
            {
                MessageBox.Show("Заполните название материала");
                return;
            }
            if (Munit.Text.Trim().Length == 0)
            {
                MessageBox.Show("Заполните единицу измерения материала");
                return;
            }
            if (Mprice.Text.Trim().Length == 0)
            {
                MessageBox.Show("Заполните цену материала");
                return;
            }
            if (Mnumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("Заполните количество материала");
                return;
            }
            if (btAddM.Text == "Добавить")
            {
                Material mtr = new Material(Mname.Text.Trim(), Munit.Text.Trim(), Mprice.Text.Trim(), Mnumber.Text.Trim());
                _2kurs0.EditMaterial.AddMaterial(mtr);
                Clear();
            }
            if (btAddM.Text == "Изменить")
            {
                Material mtr = new Material(Mname.Text.Trim(), Munit.Text.Trim(), Mprice.Text.Trim(), Mnumber.Text.Trim());
                _2kurs0.EditMaterial.UpdateMaterial(mtr, idM);
            }
            _parent.DisplayM();
        }
    }
}
