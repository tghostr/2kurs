namespace _2kurs0
{
    partial class TestForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvMat = new DataGridView();
            idS = new DataGridViewTextBoxColumn();
            SName = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            TabControl = new TabControlWithoutHeader();
            EquipPage = new TabPage();
            dateTimePicker1 = new DateTimePicker();
            SearchPanel = new Panel();
            tbSearch = new TextBox();
            btAdd = new Button();
            dgvTest = new DataGridView();
            MaterialPage = new TabPage();
            StaffPage = new TabPage();
            AuthorizationPage = new TabPage();
            RequestPage = new TabPage();
            NewRequestPage = new TabPage();
            btAddRequestTest = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMat).BeginInit();
            TabControl.SuspendLayout();
            EquipPage.SuspendLayout();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTest).BeginInit();
            SuspendLayout();
            // 
            // dgvMat
            // 
            dgvMat.AllowUserToAddRows = false;
            dgvMat.AllowUserToResizeColumns = false;
            dgvMat.AllowUserToResizeRows = false;
            dgvMat.BackgroundColor = Color.White;
            dgvMat.BorderStyle = BorderStyle.None;
            dgvMat.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(133, 133, 133);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(133, 133, 133);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMat.ColumnHeadersHeight = 35;
            dgvMat.Columns.AddRange(new DataGridViewColumn[] { idS, SName, Unit, Number });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(133, 133, 133);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMat.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMat.EnableHeadersVisualStyles = false;
            dgvMat.GridColor = Color.White;
            dgvMat.Location = new Point(148, 0);
            dgvMat.MultiSelect = false;
            dgvMat.Name = "dgvMat";
            dgvMat.RowHeadersVisible = false;
            dgvMat.RowHeadersWidth = 25;
            dgvMat.RowTemplate.DividerHeight = 1;
            dgvMat.RowTemplate.Height = 25;
            dgvMat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMat.Size = new Size(429, 408);
            dgvMat.TabIndex = 1;
            // 
            // idS
            // 
            idS.HeaderText = "#";
            idS.Name = "idS";
            // 
            // SName
            // 
            SName.HeaderText = "Название";
            SName.Name = "SName";
            // 
            // Unit
            // 
            Unit.HeaderText = "Ед.изм.";
            Unit.Name = "Unit";
            // 
            // Number
            // 
            Number.HeaderText = "Количество";
            Number.Name = "Number";
            // 
            // TabControl
            // 
            TabControl.Alignment = TabAlignment.Bottom;
            TabControl.Controls.Add(EquipPage);
            TabControl.Controls.Add(MaterialPage);
            TabControl.Controls.Add(StaffPage);
            TabControl.Controls.Add(AuthorizationPage);
            TabControl.Controls.Add(RequestPage);
            TabControl.Controls.Add(NewRequestPage);
            TabControl.Location = new Point(0, 212);
            TabControl.MinimumSize = new Size(950, 570);
            TabControl.Name = "TabControl";
            TabControl.Padding = new Point(0, 0);
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(950, 570);
            TabControl.TabIndex = 2;
            TabControl.Visible = false;
            // 
            // EquipPage
            // 
            EquipPage.Controls.Add(dateTimePicker1);
            EquipPage.Controls.Add(SearchPanel);
            EquipPage.Controls.Add(btAdd);
            EquipPage.Controls.Add(dgvTest);
            EquipPage.Location = new Point(4, 4);
            EquipPage.Name = "EquipPage";
            EquipPage.Size = new Size(942, 542);
            EquipPage.TabIndex = 0;
            EquipPage.Text = "EP";
            EquipPage.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.CalendarMonthBackground = Color.White;
            dateTimePicker1.CalendarTitleBackColor = Color.White;
            dateTimePicker1.CalendarTrailingForeColor = Color.Black;
            dateTimePicker1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(357, 20);
            dateTimePicker1.MaxDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.MinimumSize = new Size(200, 40);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 40);
            dateTimePicker1.TabIndex = 17;
            dateTimePicker1.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // SearchPanel
            // 
            SearchPanel.BackColor = Color.Transparent;
            SearchPanel.BorderStyle = BorderStyle.FixedSingle;
            SearchPanel.Controls.Add(tbSearch);
            SearchPanel.ForeColor = Color.White;
            SearchPanel.Location = new Point(30, 20);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(300, 40);
            SearchPanel.TabIndex = 7;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbSearch.BackColor = SystemColors.Window;
            tbSearch.BorderStyle = BorderStyle.None;
            tbSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tbSearch.ForeColor = SystemColors.WindowText;
            tbSearch.Location = new Point(10, 11);
            tbSearch.MaxLength = 50;
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Поиск";
            tbSearch.Size = new Size(378, 16);
            tbSearch.TabIndex = 6;
            // 
            // btAdd
            // 
            btAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btAdd.BackColor = Color.FromArgb(1, 158, 253);
            btAdd.FlatAppearance.BorderSize = 0;
            btAdd.FlatStyle = FlatStyle.Flat;
            btAdd.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btAdd.ForeColor = Color.White;
            btAdd.Image = (Image)resources.GetObject("btAdd.Image");
            btAdd.ImageAlign = ContentAlignment.MiddleRight;
            btAdd.Location = new Point(690, 20);
            btAdd.MaximumSize = new Size(140, 40);
            btAdd.MinimumSize = new Size(140, 40);
            btAdd.Name = "btAdd";
            btAdd.Padding = new Padding(3, 0, 0, 0);
            btAdd.Size = new Size(140, 40);
            btAdd.TabIndex = 3;
            btAdd.Text = "  Добавить";
            btAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btAdd.UseVisualStyleBackColor = false;
            btAdd.Click += btAdd_Click;
            // 
            // dgvTest
            // 
            dgvTest.AllowUserToAddRows = false;
            dgvTest.AllowUserToDeleteRows = false;
            dgvTest.AllowUserToResizeColumns = false;
            dgvTest.AllowUserToResizeRows = false;
            dgvTest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTest.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvTest.BorderStyle = BorderStyle.None;
            dgvTest.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTest.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(133, 133, 133);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(133, 133, 133);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTest.ColumnHeadersHeight = 35;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(133, 133, 133);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvTest.DefaultCellStyle = dataGridViewCellStyle4;
            dgvTest.EnableHeadersVisualStyles = false;
            dgvTest.GridColor = Color.White;
            dgvTest.Location = new Point(30, 80);
            dgvTest.MaximumSize = new Size(700, 400);
            dgvTest.MinimumSize = new Size(700, 400);
            dgvTest.MultiSelect = false;
            dgvTest.Name = "dgvTest";
            dgvTest.ReadOnly = true;
            dgvTest.RowHeadersVisible = false;
            dgvTest.RowHeadersWidth = 25;
            dgvTest.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvTest.RowTemplate.DividerHeight = 1;
            dgvTest.RowTemplate.Height = 25;
            dgvTest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTest.Size = new Size(700, 400);
            dgvTest.TabIndex = 0;
            dgvTest.Sorted += dgvTest_Sorted;
            // 
            // MaterialPage
            // 
            MaterialPage.Location = new Point(4, 4);
            MaterialPage.Name = "MaterialPage";
            MaterialPage.Padding = new Padding(3);
            MaterialPage.Size = new Size(942, 542);
            MaterialPage.TabIndex = 1;
            MaterialPage.Text = "MP";
            MaterialPage.UseVisualStyleBackColor = true;
            // 
            // StaffPage
            // 
            StaffPage.Location = new Point(4, 4);
            StaffPage.Name = "StaffPage";
            StaffPage.Padding = new Padding(3);
            StaffPage.Size = new Size(942, 542);
            StaffPage.TabIndex = 2;
            StaffPage.Text = "SP";
            StaffPage.UseVisualStyleBackColor = true;
            // 
            // AuthorizationPage
            // 
            AuthorizationPage.Location = new Point(4, 4);
            AuthorizationPage.Name = "AuthorizationPage";
            AuthorizationPage.Padding = new Padding(3);
            AuthorizationPage.Size = new Size(942, 542);
            AuthorizationPage.TabIndex = 3;
            AuthorizationPage.Text = "AP";
            AuthorizationPage.UseVisualStyleBackColor = true;
            // 
            // RequestPage
            // 
            RequestPage.Location = new Point(4, 4);
            RequestPage.Name = "RequestPage";
            RequestPage.Padding = new Padding(3);
            RequestPage.Size = new Size(942, 542);
            RequestPage.TabIndex = 4;
            RequestPage.Text = "RP";
            RequestPage.UseVisualStyleBackColor = true;
            // 
            // NewRequestPage
            // 
            NewRequestPage.Location = new Point(4, 4);
            NewRequestPage.Name = "NewRequestPage";
            NewRequestPage.Padding = new Padding(3);
            NewRequestPage.Size = new Size(942, 542);
            NewRequestPage.TabIndex = 5;
            NewRequestPage.Text = "NRP";
            NewRequestPage.UseVisualStyleBackColor = true;
            // 
            // btAddRequestTest
            // 
            btAddRequestTest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btAddRequestTest.BackColor = Color.FromArgb(1, 158, 253);
            btAddRequestTest.FlatAppearance.BorderSize = 0;
            btAddRequestTest.FlatStyle = FlatStyle.Flat;
            btAddRequestTest.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btAddRequestTest.ForeColor = Color.White;
            btAddRequestTest.Image = (Image)resources.GetObject("btAddRequestTest.Image");
            btAddRequestTest.ImageAlign = ContentAlignment.MiddleRight;
            btAddRequestTest.Location = new Point(635, 108);
            btAddRequestTest.MaximumSize = new Size(140, 40);
            btAddRequestTest.MinimumSize = new Size(140, 40);
            btAddRequestTest.Name = "btAddRequestTest";
            btAddRequestTest.Padding = new Padding(3, 0, 0, 0);
            btAddRequestTest.Size = new Size(140, 40);
            btAddRequestTest.TabIndex = 4;
            btAddRequestTest.Text = "  Добавить";
            btAddRequestTest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btAddRequestTest.UseVisualStyleBackColor = false;
            btAddRequestTest.Click += btAddRequestTest_Click;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 782);
            Controls.Add(dgvMat);
            Controls.Add(btAddRequestTest);
            Controls.Add(TabControl);
            Name = "TestForm";
            Text = "TestForm";
            Load += TestForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMat).EndInit();
            TabControl.ResumeLayout(false);
            EquipPage.ResumeLayout(false);
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTest).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMat;
        private TabControlWithoutHeader TabControl;
        private TabPage EquipPage;
        private Panel SearchPanel;
        private TextBox tbSearch;
        private Button btAdd;
        private DataGridView dgvTest;
        private TabPage MaterialPage;
        private TabPage StaffPage;
        private TabPage AuthorizationPage;
        private TabPage RequestPage;
        private TabPage NewRequestPage;
        private DateTimePicker dateTimePicker1;
        private Button btAddRequestTest;
        private DataGridViewTextBoxColumn idS;
        private DataGridViewTextBoxColumn SName;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Number;
    }
}