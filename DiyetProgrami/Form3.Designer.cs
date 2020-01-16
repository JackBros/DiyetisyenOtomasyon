namespace DiyetProgrami
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kullaniciAdiTxtBox = new System.Windows.Forms.TextBox();
            this.sifreTxtBox = new System.Windows.Forms.TextBox();
            this.sifreTekrarTxtBox = new System.Windows.Forms.TextBox();
            this.uyeOlButton = new System.Windows.Forms.Button();
            this.geriButton = new System.Windows.Forms.Button();
            this.cikisButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre Tekrar : ";
            // 
            // kullaniciAdiTxtBox
            // 
            this.kullaniciAdiTxtBox.Location = new System.Drawing.Point(166, 12);
            this.kullaniciAdiTxtBox.Name = "kullaniciAdiTxtBox";
            this.kullaniciAdiTxtBox.Size = new System.Drawing.Size(181, 20);
            this.kullaniciAdiTxtBox.TabIndex = 6;
            this.kullaniciAdiTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kullaniciAdiTxtBox_KeyPress);
            // 
            // sifreTxtBox
            // 
            this.sifreTxtBox.Location = new System.Drawing.Point(166, 38);
            this.sifreTxtBox.Name = "sifreTxtBox";
            this.sifreTxtBox.PasswordChar = '*';
            this.sifreTxtBox.Size = new System.Drawing.Size(181, 20);
            this.sifreTxtBox.TabIndex = 7;
            this.sifreTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sifreTxtBox_KeyPress);
            // 
            // sifreTekrarTxtBox
            // 
            this.sifreTekrarTxtBox.Location = new System.Drawing.Point(166, 64);
            this.sifreTekrarTxtBox.Name = "sifreTekrarTxtBox";
            this.sifreTekrarTxtBox.PasswordChar = '*';
            this.sifreTekrarTxtBox.Size = new System.Drawing.Size(181, 20);
            this.sifreTekrarTxtBox.TabIndex = 8;
            this.sifreTekrarTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sifreTekrarTxtBox_KeyPress);
            // 
            // uyeOlButton
            // 
            this.uyeOlButton.Location = new System.Drawing.Point(10, 103);
            this.uyeOlButton.Name = "uyeOlButton";
            this.uyeOlButton.Size = new System.Drawing.Size(109, 23);
            this.uyeOlButton.TabIndex = 12;
            this.uyeOlButton.Text = "ÜYE OL";
            this.uyeOlButton.UseVisualStyleBackColor = true;
            this.uyeOlButton.Click += new System.EventHandler(this.uyeOlButton_Click);
            // 
            // geriButton
            // 
            this.geriButton.Location = new System.Drawing.Point(125, 103);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(109, 23);
            this.geriButton.TabIndex = 13;
            this.geriButton.Text = "GERİ";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.GeriButton_Click);
            // 
            // cikisButton2
            // 
            this.cikisButton2.Location = new System.Drawing.Point(240, 103);
            this.cikisButton2.Name = "cikisButton2";
            this.cikisButton2.Size = new System.Drawing.Size(109, 23);
            this.cikisButton2.TabIndex = 14;
            this.cikisButton2.Text = "ÇIKIŞ";
            this.cikisButton2.UseVisualStyleBackColor = true;
            this.cikisButton2.Click += new System.EventHandler(this.CikisButton2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 146);
            this.Controls.Add(this.cikisButton2);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.uyeOlButton);
            this.Controls.Add(this.sifreTekrarTxtBox);
            this.Controls.Add(this.sifreTxtBox);
            this.Controls.Add(this.kullaniciAdiTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kullaniciAdiTxtBox;
        private System.Windows.Forms.TextBox sifreTxtBox;
        private System.Windows.Forms.TextBox sifreTekrarTxtBox;
        private System.Windows.Forms.Button uyeOlButton;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.Button cikisButton2;
    }
}