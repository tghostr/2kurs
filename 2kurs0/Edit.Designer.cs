namespace _2kurs0
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            lblTab = new Label();
            editTabs = new TabControlWithoutHeader();
            EditEquip = new TabPage();
            panel2 = new Panel();
            Ename = new TextBox();
            panel7 = new Panel();
            Eunit = new TextBox();
            panel8 = new Panel();
            Eprice = new TextBox();
            btAddE = new Button();
            panel9 = new Panel();
            Enumber = new TextBox();
            EditMaterial = new TabPage();
            panel6 = new Panel();
            Mname = new TextBox();
            panel5 = new Panel();
            Munit = new TextBox();
            panel3 = new Panel();
            Mprice = new TextBox();
            btAddM = new Button();
            panel4 = new Panel();
            Mnumber = new TextBox();
            EditStaff = new TabPage();
            panel10 = new Panel();
            textBox5 = new TextBox();
            panel11 = new Panel();
            textBox6 = new TextBox();
            panel12 = new Panel();
            textBox7 = new TextBox();
            button2 = new Button();
            panel13 = new Panel();
            textBox8 = new TextBox();
            EditRequest = new TabPage();
            panel1 = new Panel();
            topPanel = new Panel();
            btClose = new Button();
            editTabs.SuspendLayout();
            EditEquip.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            EditMaterial.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            EditStaff.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel1.SuspendLayout();
            topPanel.SuspendLayout();
            SuspendLayout();
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
            lblTab.Size = new Size(121, 25);
            lblTab.TabIndex = 5;
            lblTab.Text = "Добавить ";
            // 
            // editTabs
            // 
            editTabs.Alignment = TabAlignment.Bottom;
            editTabs.Controls.Add(EditEquip);
            editTabs.Controls.Add(EditMaterial);
            editTabs.Controls.Add(EditStaff);
            editTabs.Controls.Add(EditRequest);
            editTabs.Dock = DockStyle.Fill;
            editTabs.Location = new Point(0, 80);
            editTabs.Name = "editTabs";
            editTabs.SelectedIndex = 0;
            editTabs.Size = new Size(350, 370);
            editTabs.TabIndex = 9;
            // 
            // EditEquip
            // 
            EditEquip.Controls.Add(panel2);
            EditEquip.Controls.Add(panel7);
            EditEquip.Controls.Add(panel8);
            EditEquip.Controls.Add(btAddE);
            EditEquip.Controls.Add(panel9);
            EditEquip.Location = new Point(4, 4);
            EditEquip.Name = "EditEquip";
            EditEquip.Padding = new Padding(3);
            EditEquip.Size = new Size(342, 342);
            EditEquip.TabIndex = 0;
            EditEquip.Text = "Equip";
            EditEquip.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Ename);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(71, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 40);
            panel2.TabIndex = 24;
            // 
            // Ename
            // 
            Ename.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Ename.BackColor = SystemColors.Window;
            Ename.BorderStyle = BorderStyle.None;
            Ename.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Ename.ForeColor = SystemColors.WindowText;
            Ename.Location = new Point(10, 11);
            Ename.MaxLength = 50;
            Ename.Name = "Ename";
            Ename.PlaceholderText = "Название e";
            Ename.Size = new Size(165, 16);
            Ename.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(Eunit);
            panel7.ForeColor = Color.White;
            panel7.Location = new Point(71, 90);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 40);
            panel7.TabIndex = 23;
            // 
            // Eunit
            // 
            Eunit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Eunit.BackColor = SystemColors.Window;
            Eunit.BorderStyle = BorderStyle.None;
            Eunit.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Eunit.ForeColor = SystemColors.WindowText;
            Eunit.Location = new Point(10, 11);
            Eunit.MaxLength = 10;
            Eunit.Name = "Eunit";
            Eunit.PlaceholderText = "Ед. изм.";
            Eunit.Size = new Size(167, 16);
            Eunit.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(Eprice);
            panel8.ForeColor = Color.White;
            panel8.Location = new Point(71, 140);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 40);
            panel8.TabIndex = 20;
            // 
            // Eprice
            // 
            Eprice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Eprice.BackColor = SystemColors.Window;
            Eprice.BorderStyle = BorderStyle.None;
            Eprice.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Eprice.ForeColor = SystemColors.WindowText;
            Eprice.Location = new Point(10, 11);
            Eprice.MaxLength = 10;
            Eprice.Name = "Eprice";
            Eprice.PlaceholderText = "Цена";
            Eprice.Size = new Size(169, 16);
            Eprice.TabIndex = 6;
            // 
            // btAddE
            // 
            btAddE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btAddE.BackColor = Color.FromArgb(1, 158, 253);
            btAddE.FlatAppearance.BorderSize = 0;
            btAddE.FlatStyle = FlatStyle.Flat;
            btAddE.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btAddE.ForeColor = Color.White;
            btAddE.Location = new Point(71, 260);
            btAddE.MaximumSize = new Size(200, 40);
            btAddE.MinimumSize = new Size(200, 40);
            btAddE.Name = "btAddE";
            btAddE.Padding = new Padding(5, 0, 0, 0);
            btAddE.Size = new Size(200, 40);
            btAddE.TabIndex = 22;
            btAddE.Text = "Добавить";
            btAddE.TextImageRelation = TextImageRelation.ImageBeforeText;
            btAddE.UseVisualStyleBackColor = false;
            btAddE.Click += btAddE_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Transparent;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(Enumber);
            panel9.ForeColor = Color.White;
            panel9.Location = new Point(71, 190);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 40);
            panel9.TabIndex = 21;
            // 
            // Enumber
            // 
            Enumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Enumber.BackColor = SystemColors.Window;
            Enumber.BorderStyle = BorderStyle.None;
            Enumber.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Enumber.ForeColor = SystemColors.WindowText;
            Enumber.Location = new Point(10, 11);
            Enumber.MaxLength = 10;
            Enumber.Name = "Enumber";
            Enumber.PlaceholderText = "Количество";
            Enumber.Size = new Size(169, 16);
            Enumber.TabIndex = 6;
            // 
            // EditMaterial
            // 
            EditMaterial.Controls.Add(panel6);
            EditMaterial.Controls.Add(panel5);
            EditMaterial.Controls.Add(panel3);
            EditMaterial.Controls.Add(btAddM);
            EditMaterial.Controls.Add(panel4);
            EditMaterial.Location = new Point(4, 4);
            EditMaterial.Name = "EditMaterial";
            EditMaterial.Padding = new Padding(3);
            EditMaterial.Size = new Size(342, 342);
            EditMaterial.TabIndex = 1;
            EditMaterial.Text = "Material";
            EditMaterial.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(Mname);
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(71, 40);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 40);
            panel6.TabIndex = 19;
            // 
            // Mname
            // 
            Mname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Mname.BackColor = SystemColors.Window;
            Mname.BorderStyle = BorderStyle.None;
            Mname.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Mname.ForeColor = SystemColors.WindowText;
            Mname.Location = new Point(10, 11);
            Mname.MaxLength = 50;
            Mname.Name = "Mname";
            Mname.PlaceholderText = "Название m";
            Mname.Size = new Size(167, 16);
            Mname.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(Munit);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(71, 90);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 40);
            panel5.TabIndex = 14;
            // 
            // Munit
            // 
            Munit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Munit.BackColor = SystemColors.Window;
            Munit.BorderStyle = BorderStyle.None;
            Munit.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Munit.ForeColor = SystemColors.WindowText;
            Munit.Location = new Point(10, 11);
            Munit.MaxLength = 10;
            Munit.Name = "Munit";
            Munit.PlaceholderText = "Ед. изм.";
            Munit.Size = new Size(169, 16);
            Munit.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(Mprice);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(71, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 40);
            panel3.TabIndex = 11;
            // 
            // Mprice
            // 
            Mprice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Mprice.BackColor = SystemColors.Window;
            Mprice.BorderStyle = BorderStyle.None;
            Mprice.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Mprice.ForeColor = SystemColors.WindowText;
            Mprice.Location = new Point(10, 11);
            Mprice.MaxLength = 10;
            Mprice.Name = "Mprice";
            Mprice.PlaceholderText = "Цена";
            Mprice.Size = new Size(171, 16);
            Mprice.TabIndex = 6;
            // 
            // btAddM
            // 
            btAddM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btAddM.BackColor = Color.FromArgb(1, 158, 253);
            btAddM.FlatAppearance.BorderSize = 0;
            btAddM.FlatStyle = FlatStyle.Flat;
            btAddM.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btAddM.ForeColor = Color.White;
            btAddM.Location = new Point(71, 260);
            btAddM.MaximumSize = new Size(200, 40);
            btAddM.MinimumSize = new Size(200, 40);
            btAddM.Name = "btAddM";
            btAddM.Padding = new Padding(5, 0, 0, 0);
            btAddM.Size = new Size(200, 40);
            btAddM.TabIndex = 13;
            btAddM.Text = "Дабавить";
            btAddM.TextImageRelation = TextImageRelation.ImageBeforeText;
            btAddM.UseVisualStyleBackColor = false;
            btAddM.Click += btAddM_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(Mnumber);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(71, 190);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 40);
            panel4.TabIndex = 12;
            // 
            // Mnumber
            // 
            Mnumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Mnumber.BackColor = SystemColors.Window;
            Mnumber.BorderStyle = BorderStyle.None;
            Mnumber.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Mnumber.ForeColor = SystemColors.WindowText;
            Mnumber.Location = new Point(10, 11);
            Mnumber.MaxLength = 10;
            Mnumber.Name = "Mnumber";
            Mnumber.PlaceholderText = "Количество";
            Mnumber.Size = new Size(171, 16);
            Mnumber.TabIndex = 6;
            // 
            // EditStaff
            // 
            EditStaff.Controls.Add(panel10);
            EditStaff.Controls.Add(panel11);
            EditStaff.Controls.Add(panel12);
            EditStaff.Controls.Add(button2);
            EditStaff.Controls.Add(panel13);
            EditStaff.Location = new Point(4, 4);
            EditStaff.Name = "EditStaff";
            EditStaff.Padding = new Padding(3);
            EditStaff.Size = new Size(342, 342);
            EditStaff.TabIndex = 2;
            EditStaff.Text = "Staff";
            EditStaff.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(textBox5);
            panel10.ForeColor = Color.White;
            panel10.Location = new Point(71, 40);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 40);
            panel10.TabIndex = 24;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.BackColor = SystemColors.Window;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.ForeColor = SystemColors.WindowText;
            textBox5.Location = new Point(10, 11);
            textBox5.MaxLength = 20;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Название stuff";
            textBox5.Size = new Size(165, 16);
            textBox5.TabIndex = 6;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Transparent;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(textBox6);
            panel11.ForeColor = Color.White;
            panel11.Location = new Point(71, 90);
            panel11.Name = "panel11";
            panel11.Size = new Size(200, 40);
            panel11.TabIndex = 23;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.BackColor = SystemColors.Window;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.ForeColor = SystemColors.WindowText;
            textBox6.Location = new Point(10, 11);
            textBox6.MaxLength = 20;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Ед. изм.";
            textBox6.Size = new Size(167, 16);
            textBox6.TabIndex = 6;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Transparent;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(textBox7);
            panel12.ForeColor = Color.White;
            panel12.Location = new Point(71, 140);
            panel12.Name = "panel12";
            panel12.Size = new Size(200, 40);
            panel12.TabIndex = 20;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.BackColor = SystemColors.Window;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.ForeColor = SystemColors.WindowText;
            textBox7.Location = new Point(10, 11);
            textBox7.MaxLength = 20;
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Цена";
            textBox7.Size = new Size(169, 16);
            textBox7.TabIndex = 6;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(1, 158, 253);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(71, 260);
            button2.MaximumSize = new Size(200, 40);
            button2.MinimumSize = new Size(200, 40);
            button2.Name = "button2";
            button2.Padding = new Padding(5, 0, 0, 0);
            button2.Size = new Size(200, 40);
            button2.TabIndex = 22;
            button2.Text = "Дабавить";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Transparent;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(textBox8);
            panel13.ForeColor = Color.White;
            panel13.Location = new Point(71, 190);
            panel13.Name = "panel13";
            panel13.Size = new Size(200, 40);
            panel13.TabIndex = 21;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox8.BackColor = SystemColors.Window;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.ForeColor = SystemColors.WindowText;
            textBox8.Location = new Point(10, 11);
            textBox8.MaxLength = 20;
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Количество";
            textBox8.Size = new Size(169, 16);
            textBox8.TabIndex = 6;
            // 
            // EditRequest
            // 
            EditRequest.Location = new Point(4, 4);
            EditRequest.Name = "EditRequest";
            EditRequest.Padding = new Padding(3);
            EditRequest.Size = new Size(342, 342);
            EditRequest.TabIndex = 3;
            EditRequest.Text = "Request";
            EditRequest.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(69, 70, 79);
            panel1.Controls.Add(lblTab);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 50);
            panel1.TabIndex = 10;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(36, 38, 48);
            topPanel.Controls.Add(btClose);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(350, 30);
            topPanel.TabIndex = 8;
            topPanel.MouseDown += topPanel_MouseDown;
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
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 450);
            Controls.Add(editTabs);
            Controls.Add(panel1);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            Load += Edit_Load;
            editTabs.ResumeLayout(false);
            EditEquip.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            EditMaterial.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            EditStaff.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTab;
        private TabControlWithoutHeader editTabs;
        private TabPage EditEquip;
        private TabPage EditMaterial;
        private Panel panel6;
        private TextBox Mname;
        private Panel panel5;
        private TextBox Munit;
        private Panel panel3;
        private TextBox Mprice;
        private Button btAddM;
        private Panel panel4;
        private TextBox Mnumber;
        private Panel panel1;
        private Panel topPanel;
        private Button btClose;
        private TabPage EditStaff;
        private TabPage EditRequest;
        private Panel panel2;
        private TextBox Ename;
        private Panel panel7;
        private TextBox Eunit;
        private Panel panel8;
        private TextBox Eprice;
        private Button btAddE;
        private Panel panel9;
        private TextBox Enumber;
        private Panel panel10;
        private TextBox textBox5;
        private Panel panel11;
        private TextBox textBox6;
        private Panel panel12;
        private TextBox textBox7;
        private Button button2;
        private Panel panel13;
        private TextBox textBox8;
    }
}