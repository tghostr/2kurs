using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2kurs0.Controls
{
    public partial class btMenu : UserControl
    {
        //private bool MouseEntered = false;

        //protected override void OnMouseEnter(EventArgs e)
        //{
        //    base.OnMouseEnter(e);
        //    MouseEntered = true;
        //}
        //protected override void OnMouseLeave(EventArgs e)
        //{
        //    base.OnMouseLeave(e);
        //    MouseEntered = false;
        //}

        Image image = null;
        public string TabName
        {
            get { return tabName.Text; }
            set { tabName.Text = value; }
        }
        public Image MyImage
        {
            get { return tabPicture.Image; }
            set { tabPicture.Image = value; }
        }
        //public Color MouseOverBackColor { get; set; }


        public btMenu()
        {
            InitializeComponent();

        }

        private void tabPicture_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(79, 81, 89);
            tabName.ForeColor = Color.White;
            //panel2.BackColor = Color.FromArgb(79, 81, 89);
            //tabName.BackColor = Color.FromArgb(79, 81, 89);
            //tabPicture.BackColor = Color.FromArgb(79, 81, 89);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(41, 41, 49);
            tabName.ForeColor = Color.Gray;
            //panel2.BackColor = Color.FromArgb(41, 41, 49);
            //tabName.BackColor = Color.FromArgb(41, 41, 49);
            //tabPicture.BackColor = Color.FromArgb(41, 41, 49);
        }

        //private void panel2_MouseClick(object sender, MouseEventArgs e)
        //{
        //    this.BackColor = Color.FromArgb(74, 75, 83);
        //}
    }
}
