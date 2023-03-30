namespace _2kurs0.Controls
{
    partial class btMenu
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabName = new System.Windows.Forms.Label();
            this.tabPicture = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabName);
            this.panel2.Controls.Add(this.tabPicture);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 50);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.tabPicture_Click);
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // tabName
            // 
            this.tabName.AutoSize = true;
            this.tabName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabName.ForeColor = System.Drawing.Color.Gray;
            this.tabName.Location = new System.Drawing.Point(57, 18);
            this.tabName.Name = "tabName";
            this.tabName.Size = new System.Drawing.Size(128, 16);
            this.tabName.TabIndex = 1;
            this.tabName.Text = "Название вкладки";
            this.tabName.Click += new System.EventHandler(this.tabPicture_Click);
            this.tabName.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.tabName.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // tabPicture
            // 
            this.tabPicture.Location = new System.Drawing.Point(12, 12);
            this.tabPicture.Name = "tabPicture";
            this.tabPicture.Size = new System.Drawing.Size(26, 26);
            this.tabPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tabPicture.TabIndex = 0;
            this.tabPicture.TabStop = false;
            this.tabPicture.Click += new System.EventHandler(this.tabPicture_Click);
            this.tabPicture.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.tabPicture.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // btMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.panel2);
            this.Name = "btMenu";
            this.Size = new System.Drawing.Size(250, 50);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private PictureBox tabPicture;
        public Label tabName;
    }
}
