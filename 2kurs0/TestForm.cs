using kursproga;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System.Data;
using Image = System.Drawing.Image;
using DGVPrinterHelper;
using System.Windows.Forms;

namespace _2kurs0
{
    public partial class TestForm : Form
    {
        
        public TestForm()
        {
            InitializeComponent();
            /*DataGridViewRow row = this.dgvTest.RowTemplate;
            row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            row.DefaultCellStyle.ForeColor = Color.FromArgb(79, 79, 81);
            row.Height = 35;
            row.MinimumHeight = 35;*/
            DataSet ds = new DataSet();
            dgvMat.DataSource = ds;
        }
        #region T
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        public void deleteColumns(DataGridView dgv)
        {
            int CellCount = dgv.Columns.Count - 1;
            dgv.Columns.Remove(dgv.Columns[CellCount]);
        }
        public void addColumns(DataGridView dgv)
        {
            DataGridViewImageColumn editColumn = new DataGridViewImageColumn();
            editColumn.Name = " ";
            dgv.Columns.Add(editColumn);
            Image editImage = new Bitmap("C:\\Users\\Ghost\\Downloads\\icons\\edit.jpg");
            editImage = resizeImage(editImage, new Size(15, 15));
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells[" "].Value = editImage;
            }
            DataGridViewColumn column0 = dgv.Columns[6];
            column0.Width = 20;
            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn();
            deleteColumn.Name = "  ";
            dgv.Columns.Add(deleteColumn);
            Image deleteImage = new Bitmap("C:\\Users\\Ghost\\Downloads\\icons\\delete.jpg");
            deleteImage = resizeImage(deleteImage, new Size(15, 15));
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["  "].Value = deleteImage;
            }
            DataGridViewColumn column1 = dgv.Columns[7];
            column1.Width = 20;
        }
        #endregion
        private void TestForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("Select * from `equipment`", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            dgvTest.DataSource = table;

            dgvTest.Columns[0].HeaderText = "#";
            dgvTest.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTest.Columns[0].FillWeight = 40;
            dgvTest.Columns[0].ReadOnly = true;
            dgvTest.Columns[1].HeaderText = "Название";
            dgvTest.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTest.Columns[1].FillWeight = 220;
            dgvTest.Columns[2].HeaderText = "Ед. изм.";
            dgvTest.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTest.Columns[2].FillWeight = 100;
            dgvTest.Columns[3].HeaderText = "Цена";
            dgvTest.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTest.Columns[3].FillWeight = 100;
            dgvTest.Columns[4].HeaderText = "Количество";
            dgvTest.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTest.Columns[4].FillWeight = 100;
            dgvTest.Columns[5].HeaderText = "Стоимость";
            dgvTest.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTest.Columns[5].FillWeight = 100;
            addColumns(dgvTest);
            dgvTest.Columns[6].FillWeight = 20;
            dgvTest.Columns[7].FillWeight = 20;


            /*DB dbM = new DB();
            DataTable tableM = new DataTable();
            MySqlDataAdapter adapterM = new MySqlDataAdapter();
            MySqlCommand commandM = new MySqlCommand("Select `maname`, `maunit`, `manumber` from `material`", dbM.getConnection());
            adapterM.SelectCommand = commandM;
            adapterM.Fill(tableM);
            dgvMat.DataSource = tableM;

            dgvMat.Columns[0].HeaderText = "#";
            dgvMat.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMat.Columns[0].FillWeight = 40;
            dgvMat.Columns[0].ReadOnly = true;
            dgvMat.Columns[1].HeaderText = "Название";
            dgvMat.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMat.Columns[1].FillWeight = 220;
            dgvMat.Columns[2].HeaderText = "Ед. изм.";
            dgvMat.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMat.Columns[2].FillWeight = 100;
            dgvMat.Columns[3].HeaderText = "Цена";
            dgvMat.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMat.Columns[3].FillWeight = 100;
            dgvMat.Columns[4].HeaderText = "Количество";
            dgvMat.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMat.Columns[4].FillWeight = 100;
            dgvMat.Columns[5].HeaderText = "Стоимость";
            dgvMat.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMat.Columns[5].FillWeight = 100;*/

            //ReportDataSource rs = new ReportDataSource();
        }
        
        private void dgvTest_Sorted(object sender, EventArgs e)
        {
            deleteColumns(dgvTest);
            deleteColumns(dgvTest);
            addColumns(dgvTest);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //Edit form = new Edit();
            //form.ShowDialog();
            //form.GoToTab(0);
        }

        ReportDataSource rs = new ReportDataSource();
        private void btAddRequestTest_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = (Global.GlobalVar + "PEPEPEp");
            printer.SubTitle = string.Format("", printer.SubTitleColor = Color.Black, printer);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false; // if you need page numbers you can keep this as true other wise false
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "ООО БайТекс"; //this is the footer
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dgvMat);
        }
    }
}
