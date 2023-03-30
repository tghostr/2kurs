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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMat = new System.Windows.Forms.DataGridView();
            this.idS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl = new _2kurs0.TabControlWithoutHeader();
            this.EquipPage = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.MaterialPage = new System.Windows.Forms.TabPage();
            this.StaffPage = new System.Windows.Forms.TabPage();
            this.AuthorizationPage = new System.Windows.Forms.TabPage();
            this.RequestPage = new System.Windows.Forms.TabPage();
            this.NewRequestPage = new System.Windows.Forms.TabPage();
            this.btAddRequestTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).BeginInit();
            this.TabControl.SuspendLayout();
            this.EquipPage.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMat
            // 
            this.dgvMat.AllowUserToAddRows = false;
            this.dgvMat.AllowUserToResizeColumns = false;
            this.dgvMat.AllowUserToResizeRows = false;
            this.dgvMat.BackgroundColor = System.Drawing.Color.White;
            this.dgvMat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMat.ColumnHeadersHeight = 35;
            this.dgvMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idS,
            this.SName,
            this.Unit,
            this.Number});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMat.EnableHeadersVisualStyles = false;
            this.dgvMat.GridColor = System.Drawing.Color.White;
            this.dgvMat.Location = new System.Drawing.Point(148, 0);
            this.dgvMat.MultiSelect = false;
            this.dgvMat.Name = "dgvMat";
            this.dgvMat.RowHeadersVisible = false;
            this.dgvMat.RowHeadersWidth = 25;
            this.dgvMat.RowTemplate.DividerHeight = 1;
            this.dgvMat.RowTemplate.Height = 25;
            this.dgvMat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMat.Size = new System.Drawing.Size(429, 408);
            this.dgvMat.TabIndex = 1;
            // 
            // idS
            // 
            this.idS.HeaderText = "#";
            this.idS.Name = "idS";
            // 
            // SName
            // 
            this.SName.HeaderText = "Название";
            this.SName.Name = "SName";
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Ед.изм.";
            this.Unit.Name = "Unit";
            // 
            // Number
            // 
            this.Number.HeaderText = "Количество";
            this.Number.Name = "Number";
            // 
            // TabControl
            // 
            this.TabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.TabControl.Controls.Add(this.EquipPage);
            this.TabControl.Controls.Add(this.MaterialPage);
            this.TabControl.Controls.Add(this.StaffPage);
            this.TabControl.Controls.Add(this.AuthorizationPage);
            this.TabControl.Controls.Add(this.RequestPage);
            this.TabControl.Controls.Add(this.NewRequestPage);
            this.TabControl.Location = new System.Drawing.Point(0, 212);
            this.TabControl.MinimumSize = new System.Drawing.Size(950, 570);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Drawing.Point(0, 0);
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(950, 570);
            this.TabControl.TabIndex = 2;
            this.TabControl.Visible = false;
            // 
            // EquipPage
            // 
            this.EquipPage.Controls.Add(this.dateTimePicker1);
            this.EquipPage.Controls.Add(this.SearchPanel);
            this.EquipPage.Controls.Add(this.btAdd);
            this.EquipPage.Controls.Add(this.dgvTest);
            this.EquipPage.Location = new System.Drawing.Point(4, 4);
            this.EquipPage.Name = "EquipPage";
            this.EquipPage.Size = new System.Drawing.Size(942, 542);
            this.EquipPage.TabIndex = 0;
            this.EquipPage.Text = "EP";
            this.EquipPage.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(357, 20);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(200, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 40);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPanel.Controls.Add(this.tbSearch);
            this.SearchPanel.ForeColor = System.Drawing.Color.White;
            this.SearchPanel.Location = new System.Drawing.Point(30, 20);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(300, 40);
            this.SearchPanel.TabIndex = 7;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbSearch.Location = new System.Drawing.Point(10, 11);
            this.tbSearch.MaxLength = 50;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderText = "Поиск";
            this.tbSearch.Size = new System.Drawing.Size(378, 16);
            this.tbSearch.TabIndex = 6;
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdd.Location = new System.Drawing.Point(690, 20);
            this.btAdd.MaximumSize = new System.Drawing.Size(140, 40);
            this.btAdd.MinimumSize = new System.Drawing.Size(140, 40);
            this.btAdd.Name = "btAdd";
            this.btAdd.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btAdd.Size = new System.Drawing.Size(140, 40);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "  Добавить";
            this.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dgvTest
            // 
            this.dgvTest.AllowUserToAddRows = false;
            this.dgvTest.AllowUserToDeleteRows = false;
            this.dgvTest.AllowUserToResizeColumns = false;
            this.dgvTest.AllowUserToResizeRows = false;
            this.dgvTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTest.ColumnHeadersHeight = 35;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTest.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTest.EnableHeadersVisualStyles = false;
            this.dgvTest.GridColor = System.Drawing.Color.White;
            this.dgvTest.Location = new System.Drawing.Point(30, 80);
            this.dgvTest.MaximumSize = new System.Drawing.Size(700, 400);
            this.dgvTest.MinimumSize = new System.Drawing.Size(700, 400);
            this.dgvTest.MultiSelect = false;
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.ReadOnly = true;
            this.dgvTest.RowHeadersVisible = false;
            this.dgvTest.RowHeadersWidth = 25;
            this.dgvTest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTest.RowTemplate.DividerHeight = 1;
            this.dgvTest.RowTemplate.Height = 25;
            this.dgvTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTest.Size = new System.Drawing.Size(700, 400);
            this.dgvTest.TabIndex = 0;
            this.dgvTest.Sorted += new System.EventHandler(this.dgvTest_Sorted);
            // 
            // MaterialPage
            // 
            this.MaterialPage.Location = new System.Drawing.Point(4, 4);
            this.MaterialPage.Name = "MaterialPage";
            this.MaterialPage.Padding = new System.Windows.Forms.Padding(3);
            this.MaterialPage.Size = new System.Drawing.Size(942, 542);
            this.MaterialPage.TabIndex = 1;
            this.MaterialPage.Text = "MP";
            this.MaterialPage.UseVisualStyleBackColor = true;
            // 
            // StaffPage
            // 
            this.StaffPage.Location = new System.Drawing.Point(4, 4);
            this.StaffPage.Name = "StaffPage";
            this.StaffPage.Padding = new System.Windows.Forms.Padding(3);
            this.StaffPage.Size = new System.Drawing.Size(942, 542);
            this.StaffPage.TabIndex = 2;
            this.StaffPage.Text = "SP";
            this.StaffPage.UseVisualStyleBackColor = true;
            // 
            // AuthorizationPage
            // 
            this.AuthorizationPage.Location = new System.Drawing.Point(4, 4);
            this.AuthorizationPage.Name = "AuthorizationPage";
            this.AuthorizationPage.Padding = new System.Windows.Forms.Padding(3);
            this.AuthorizationPage.Size = new System.Drawing.Size(942, 542);
            this.AuthorizationPage.TabIndex = 3;
            this.AuthorizationPage.Text = "AP";
            this.AuthorizationPage.UseVisualStyleBackColor = true;
            // 
            // RequestPage
            // 
            this.RequestPage.Location = new System.Drawing.Point(4, 4);
            this.RequestPage.Name = "RequestPage";
            this.RequestPage.Padding = new System.Windows.Forms.Padding(3);
            this.RequestPage.Size = new System.Drawing.Size(942, 542);
            this.RequestPage.TabIndex = 4;
            this.RequestPage.Text = "RP";
            this.RequestPage.UseVisualStyleBackColor = true;
            // 
            // NewRequestPage
            // 
            this.NewRequestPage.Location = new System.Drawing.Point(4, 4);
            this.NewRequestPage.Name = "NewRequestPage";
            this.NewRequestPage.Padding = new System.Windows.Forms.Padding(3);
            this.NewRequestPage.Size = new System.Drawing.Size(942, 542);
            this.NewRequestPage.TabIndex = 5;
            this.NewRequestPage.Text = "NRP";
            this.NewRequestPage.UseVisualStyleBackColor = true;
            // 
            // btAddRequestTest
            // 
            this.btAddRequestTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddRequestTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.btAddRequestTest.FlatAppearance.BorderSize = 0;
            this.btAddRequestTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddRequestTest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAddRequestTest.ForeColor = System.Drawing.Color.White;
            this.btAddRequestTest.Image = ((System.Drawing.Image)(resources.GetObject("btAddRequestTest.Image")));
            this.btAddRequestTest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAddRequestTest.Location = new System.Drawing.Point(635, 108);
            this.btAddRequestTest.MaximumSize = new System.Drawing.Size(140, 40);
            this.btAddRequestTest.MinimumSize = new System.Drawing.Size(140, 40);
            this.btAddRequestTest.Name = "btAddRequestTest";
            this.btAddRequestTest.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btAddRequestTest.Size = new System.Drawing.Size(140, 40);
            this.btAddRequestTest.TabIndex = 4;
            this.btAddRequestTest.Text = "  Добавить";
            this.btAddRequestTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAddRequestTest.UseVisualStyleBackColor = false;
            this.btAddRequestTest.Click += new System.EventHandler(this.btAddRequestTest_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 782);
            this.Controls.Add(this.dgvMat);
            this.Controls.Add(this.btAddRequestTest);
            this.Controls.Add(this.TabControl);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.EquipPage.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.ResumeLayout(false);

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