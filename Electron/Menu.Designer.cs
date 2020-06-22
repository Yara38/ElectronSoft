namespace Electron
{
    partial class Menu
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonOpenProduct = new System.Windows.Forms.Button();
            this.buttonOpenCours = new System.Windows.Forms.Button();
            this.buttonOpenContacts = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenProduct
            // 
            this.buttonOpenProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonOpenProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonOpenProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenProduct.ForeColor = System.Drawing.Color.Black;
            this.buttonOpenProduct.Location = new System.Drawing.Point(21, 56);
            this.buttonOpenProduct.Name = "buttonOpenProduct";
            this.buttonOpenProduct.Size = new System.Drawing.Size(223, 59);
            this.buttonOpenProduct.TabIndex = 0;
            this.buttonOpenProduct.Text = "Товары";
            this.buttonOpenProduct.UseVisualStyleBackColor = false;
            this.buttonOpenProduct.Click += new System.EventHandler(this.buttonOpenProduct_Click);
            // 
            // buttonOpenCours
            // 
            this.buttonOpenCours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonOpenCours.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenCours.Location = new System.Drawing.Point(21, 131);
            this.buttonOpenCours.Name = "buttonOpenCours";
            this.buttonOpenCours.Size = new System.Drawing.Size(223, 59);
            this.buttonOpenCours.TabIndex = 1;
            this.buttonOpenCours.Text = "Курсы";
            this.buttonOpenCours.UseVisualStyleBackColor = false;
            this.buttonOpenCours.Click += new System.EventHandler(this.buttonOpenCours_Click);
            // 
            // buttonOpenContacts
            // 
            this.buttonOpenContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonOpenContacts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenContacts.Location = new System.Drawing.Point(21, 206);
            this.buttonOpenContacts.Name = "buttonOpenContacts";
            this.buttonOpenContacts.Size = new System.Drawing.Size(223, 59);
            this.buttonOpenContacts.TabIndex = 2;
            this.buttonOpenContacts.Text = "Контакты";
            this.buttonOpenContacts.UseVisualStyleBackColor = false;
            this.buttonOpenContacts.Click += new System.EventHandler(this.buttonOpenContacts_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Electron.Properties.Resources._1c;
            this.pictureBox1.Location = new System.Drawing.Point(8, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.Location = new System.Drawing.Point(22, 22);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(0, 16);
            this.labelHello.TabIndex = 5;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(265, 326);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonOpenContacts);
            this.Controls.Add(this.buttonOpenCours);
            this.Controls.Add(this.buttonOpenProduct);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электрон";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenProduct;
        private System.Windows.Forms.Button buttonOpenCours;
        private System.Windows.Forms.Button buttonOpenContacts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHello;
    }
}

