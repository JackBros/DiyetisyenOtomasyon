namespace DiyetProgrami
{
    partial class Form2
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
            this.diyetisyenKayitButton = new System.Windows.Forms.Button();
            this.girisButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.cikisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // diyetisyenKayitButton
            // 
            this.diyetisyenKayitButton.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diyetisyenKayitButton.Location = new System.Drawing.Point(12, 12);
            this.diyetisyenKayitButton.Name = "diyetisyenKayitButton";
            this.diyetisyenKayitButton.Size = new System.Drawing.Size(255, 115);
            this.diyetisyenKayitButton.TabIndex = 0;
            this.diyetisyenKayitButton.Text = "DİYETİSYEN KAYIT";
            this.diyetisyenKayitButton.UseVisualStyleBackColor = true;
            this.diyetisyenKayitButton.Click += new System.EventHandler(this.KayitButton_Click);
            // 
            // girisButton
            // 
            this.girisButton.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisButton.Location = new System.Drawing.Point(277, 12);
            this.girisButton.Name = "girisButton";
            this.girisButton.Size = new System.Drawing.Size(255, 115);
            this.girisButton.TabIndex = 1;
            this.girisButton.Text = "DİYETİSYEN GİRİŞ";
            this.girisButton.UseVisualStyleBackColor = true;
            this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.Location = new System.Drawing.Point(12, 160);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(255, 115);
            this.adminButton.TabIndex = 2;
            this.adminButton.Text = "ŞİFRE DEĞİŞTİR";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // cikisButton
            // 
            this.cikisButton.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisButton.Location = new System.Drawing.Point(277, 160);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(255, 115);
            this.cikisButton.TabIndex = 3;
            this.cikisButton.Text = "ÇIKIŞ";
            this.cikisButton.UseVisualStyleBackColor = true;
            this.cikisButton.Click += new System.EventHandler(this.Cikisbutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiyetProgrami.Properties.Resources.diyetgiris;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 281);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.girisButton);
            this.Controls.Add(this.diyetisyenKayitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button diyetisyenKayitButton;
        private System.Windows.Forms.Button girisButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button cikisButton;
    }
}