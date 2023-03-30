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
            this.lblTab = new System.Windows.Forms.Label();
            this.editTabs = new _2kurs0.TabControlWithoutHeader();
            this.EditEquip = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Ename = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Eunit = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Eprice = new System.Windows.Forms.TextBox();
            this.btAddE = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Enumber = new System.Windows.Forms.TextBox();
            this.EditMaterial = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Mname = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Munit = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Mprice = new System.Windows.Forms.TextBox();
            this.btAddM = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Mnumber = new System.Windows.Forms.TextBox();
            this.EditStaff = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.EditRequest = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.editTabs.SuspendLayout();
            this.EditEquip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.EditMaterial.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.EditStaff.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.lblTab.Size = new System.Drawing.Size(121, 25);
            this.lblTab.TabIndex = 5;
            this.lblTab.Text = "Добавить ";
            // 
            // editTabs
            // 
            this.editTabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.editTabs.Controls.Add(this.EditEquip);
            this.editTabs.Controls.Add(this.EditMaterial);
            this.editTabs.Controls.Add(this.EditStaff);
            this.editTabs.Controls.Add(this.EditRequest);
            this.editTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editTabs.Location = new System.Drawing.Point(0, 80);
            this.editTabs.Name = "editTabs";
            this.editTabs.SelectedIndex = 0;
            this.editTabs.Size = new System.Drawing.Size(350, 370);
            this.editTabs.TabIndex = 9;
            // 
            // EditEquip
            // 
            this.EditEquip.Controls.Add(this.panel2);
            this.EditEquip.Controls.Add(this.panel7);
            this.EditEquip.Controls.Add(this.panel8);
            this.EditEquip.Controls.Add(this.btAddE);
            this.EditEquip.Controls.Add(this.panel9);
            this.EditEquip.Location = new System.Drawing.Point(4, 4);
            this.EditEquip.Name = "EditEquip";
            this.EditEquip.Padding = new System.Windows.Forms.Padding(3);
            this.EditEquip.Size = new System.Drawing.Size(342, 342);
            this.EditEquip.TabIndex = 0;
            this.EditEquip.Text = "Equip";
            this.EditEquip.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Ename);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(71, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 40);
            this.panel2.TabIndex = 24;
            // 
            // Ename
            // 
            this.Ename.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ename.BackColor = System.Drawing.SystemColors.Window;
            this.Ename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ename.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ename.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Ename.Location = new System.Drawing.Point(10, 11);
            this.Ename.MaxLength = 50;
            this.Ename.Name = "Ename";
            this.Ename.PlaceholderText = "Название e";
            this.Ename.Size = new System.Drawing.Size(165, 16);
            this.Ename.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.Eunit);
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(71, 90);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 40);
            this.panel7.TabIndex = 23;
            // 
            // Eunit
            // 
            this.Eunit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Eunit.BackColor = System.Drawing.SystemColors.Window;
            this.Eunit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Eunit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Eunit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Eunit.Location = new System.Drawing.Point(10, 11);
            this.Eunit.MaxLength = 10;
            this.Eunit.Name = "Eunit";
            this.Eunit.PlaceholderText = "Ед. изм.";
            this.Eunit.Size = new System.Drawing.Size(167, 16);
            this.Eunit.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.Eprice);
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(71, 140);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 40);
            this.panel8.TabIndex = 20;
            // 
            // Eprice
            // 
            this.Eprice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Eprice.BackColor = System.Drawing.SystemColors.Window;
            this.Eprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Eprice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Eprice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Eprice.Location = new System.Drawing.Point(10, 11);
            this.Eprice.MaxLength = 10;
            this.Eprice.Name = "Eprice";
            this.Eprice.PlaceholderText = "Цена";
            this.Eprice.Size = new System.Drawing.Size(169, 16);
            this.Eprice.TabIndex = 6;
            // 
            // btAddE
            // 
            this.btAddE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.btAddE.FlatAppearance.BorderSize = 0;
            this.btAddE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddE.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAddE.ForeColor = System.Drawing.Color.White;
            this.btAddE.Location = new System.Drawing.Point(71, 260);
            this.btAddE.MaximumSize = new System.Drawing.Size(200, 40);
            this.btAddE.MinimumSize = new System.Drawing.Size(200, 40);
            this.btAddE.Name = "btAddE";
            this.btAddE.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btAddE.Size = new System.Drawing.Size(200, 40);
            this.btAddE.TabIndex = 22;
            this.btAddE.Text = "Добавить";
            this.btAddE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAddE.UseVisualStyleBackColor = false;
            this.btAddE.Click += new System.EventHandler(this.btAddE_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.Enumber);
            this.panel9.ForeColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(71, 190);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 40);
            this.panel9.TabIndex = 21;
            // 
            // Enumber
            // 
            this.Enumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Enumber.BackColor = System.Drawing.SystemColors.Window;
            this.Enumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Enumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Enumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Enumber.Location = new System.Drawing.Point(10, 11);
            this.Enumber.MaxLength = 10;
            this.Enumber.Name = "Enumber";
            this.Enumber.PlaceholderText = "Количество";
            this.Enumber.Size = new System.Drawing.Size(169, 16);
            this.Enumber.TabIndex = 6;
            // 
            // EditMaterial
            // 
            this.EditMaterial.Controls.Add(this.panel6);
            this.EditMaterial.Controls.Add(this.panel5);
            this.EditMaterial.Controls.Add(this.panel3);
            this.EditMaterial.Controls.Add(this.btAddM);
            this.EditMaterial.Controls.Add(this.panel4);
            this.EditMaterial.Location = new System.Drawing.Point(4, 4);
            this.EditMaterial.Name = "EditMaterial";
            this.EditMaterial.Padding = new System.Windows.Forms.Padding(3);
            this.EditMaterial.Size = new System.Drawing.Size(342, 342);
            this.EditMaterial.TabIndex = 1;
            this.EditMaterial.Text = "Material";
            this.EditMaterial.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Mname);
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(71, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 40);
            this.panel6.TabIndex = 19;
            // 
            // Mname
            // 
            this.Mname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mname.BackColor = System.Drawing.SystemColors.Window;
            this.Mname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Mname.Location = new System.Drawing.Point(10, 11);
            this.Mname.MaxLength = 50;
            this.Mname.Name = "Mname";
            this.Mname.PlaceholderText = "Название m";
            this.Mname.Size = new System.Drawing.Size(167, 16);
            this.Mname.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Munit);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(71, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 40);
            this.panel5.TabIndex = 14;
            // 
            // Munit
            // 
            this.Munit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Munit.BackColor = System.Drawing.SystemColors.Window;
            this.Munit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Munit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Munit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Munit.Location = new System.Drawing.Point(10, 11);
            this.Munit.MaxLength = 10;
            this.Munit.Name = "Munit";
            this.Munit.PlaceholderText = "Ед. изм.";
            this.Munit.Size = new System.Drawing.Size(169, 16);
            this.Munit.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Mprice);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(71, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 40);
            this.panel3.TabIndex = 11;
            // 
            // Mprice
            // 
            this.Mprice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mprice.BackColor = System.Drawing.SystemColors.Window;
            this.Mprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mprice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mprice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Mprice.Location = new System.Drawing.Point(10, 11);
            this.Mprice.MaxLength = 10;
            this.Mprice.Name = "Mprice";
            this.Mprice.PlaceholderText = "Цена";
            this.Mprice.Size = new System.Drawing.Size(171, 16);
            this.Mprice.TabIndex = 6;
            // 
            // btAddM
            // 
            this.btAddM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.btAddM.FlatAppearance.BorderSize = 0;
            this.btAddM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAddM.ForeColor = System.Drawing.Color.White;
            this.btAddM.Location = new System.Drawing.Point(71, 260);
            this.btAddM.MaximumSize = new System.Drawing.Size(200, 40);
            this.btAddM.MinimumSize = new System.Drawing.Size(200, 40);
            this.btAddM.Name = "btAddM";
            this.btAddM.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btAddM.Size = new System.Drawing.Size(200, 40);
            this.btAddM.TabIndex = 13;
            this.btAddM.Text = "Дабавить";
            this.btAddM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAddM.UseVisualStyleBackColor = false;
            this.btAddM.Click += new System.EventHandler(this.btAddM_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Mnumber);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(71, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 40);
            this.panel4.TabIndex = 12;
            // 
            // Mnumber
            // 
            this.Mnumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mnumber.BackColor = System.Drawing.SystemColors.Window;
            this.Mnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mnumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mnumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Mnumber.Location = new System.Drawing.Point(10, 11);
            this.Mnumber.MaxLength = 10;
            this.Mnumber.Name = "Mnumber";
            this.Mnumber.PlaceholderText = "Количество";
            this.Mnumber.Size = new System.Drawing.Size(171, 16);
            this.Mnumber.TabIndex = 6;
            // 
            // EditStaff
            // 
            this.EditStaff.Controls.Add(this.panel10);
            this.EditStaff.Controls.Add(this.panel11);
            this.EditStaff.Controls.Add(this.panel12);
            this.EditStaff.Controls.Add(this.button2);
            this.EditStaff.Controls.Add(this.panel13);
            this.EditStaff.Location = new System.Drawing.Point(4, 4);
            this.EditStaff.Name = "EditStaff";
            this.EditStaff.Padding = new System.Windows.Forms.Padding(3);
            this.EditStaff.Size = new System.Drawing.Size(342, 342);
            this.EditStaff.TabIndex = 2;
            this.EditStaff.Text = "Staff";
            this.EditStaff.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.textBox5);
            this.panel10.ForeColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(71, 40);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 40);
            this.panel10.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox5.Location = new System.Drawing.Point(10, 11);
            this.textBox5.MaxLength = 20;
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "Название stuff";
            this.textBox5.Size = new System.Drawing.Size(165, 16);
            this.textBox5.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Transparent;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.textBox6);
            this.panel11.ForeColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(71, 90);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 40);
            this.panel11.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox6.Location = new System.Drawing.Point(10, 11);
            this.textBox6.MaxLength = 20;
            this.textBox6.Name = "textBox6";
            this.textBox6.PlaceholderText = "Ед. изм.";
            this.textBox6.Size = new System.Drawing.Size(167, 16);
            this.textBox6.TabIndex = 6;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.textBox7);
            this.panel12.ForeColor = System.Drawing.Color.White;
            this.panel12.Location = new System.Drawing.Point(71, 140);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 40);
            this.panel12.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.BackColor = System.Drawing.SystemColors.Window;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox7.Location = new System.Drawing.Point(10, 11);
            this.textBox7.MaxLength = 20;
            this.textBox7.Name = "textBox7";
            this.textBox7.PlaceholderText = "Цена";
            this.textBox7.Size = new System.Drawing.Size(169, 16);
            this.textBox7.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(158)))), ((int)(((byte)(253)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(71, 260);
            this.button2.MaximumSize = new System.Drawing.Size(200, 40);
            this.button2.MinimumSize = new System.Drawing.Size(200, 40);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "Дабавить";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Transparent;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.textBox8);
            this.panel13.ForeColor = System.Drawing.Color.White;
            this.panel13.Location = new System.Drawing.Point(71, 190);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(200, 40);
            this.panel13.TabIndex = 21;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.BackColor = System.Drawing.SystemColors.Window;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox8.Location = new System.Drawing.Point(10, 11);
            this.textBox8.MaxLength = 20;
            this.textBox8.Name = "textBox8";
            this.textBox8.PlaceholderText = "Количество";
            this.textBox8.Size = new System.Drawing.Size(169, 16);
            this.textBox8.TabIndex = 6;
            // 
            // EditRequest
            // 
            this.EditRequest.Location = new System.Drawing.Point(4, 4);
            this.EditRequest.Name = "EditRequest";
            this.EditRequest.Padding = new System.Windows.Forms.Padding(3);
            this.EditRequest.Size = new System.Drawing.Size(342, 342);
            this.EditRequest.TabIndex = 3;
            this.EditRequest.Text = "Request";
            this.EditRequest.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.lblTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 50);
            this.panel1.TabIndex = 10;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.topPanel.Controls.Add(this.btClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(350, 30);
            this.topPanel.TabIndex = 8;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
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
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.editTabs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.editTabs.ResumeLayout(false);
            this.EditEquip.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.EditMaterial.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.EditStaff.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

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