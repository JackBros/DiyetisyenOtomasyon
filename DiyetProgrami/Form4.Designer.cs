namespace DiyetProgrami
{
    partial class Form4
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
            this.cikisButton2 = new System.Windows.Forms.Button();
            this.geriButton = new System.Windows.Forms.Button();
            this.sifreDegisButton = new System.Windows.Forms.Button();
            this.yeniSifreTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yeniSifreTekrarTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cikisButton2
            // 
            this.cikisButton2.Location = new System.Drawing.Point(286, 172);
            this.cikisButton2.Name = "cikisButton2";
            this.cikisButton2.Size = new System.Drawing.Size(109, 23);
            this.cikisButton2.TabIndex = 23;
            this.cikisButton2.Text = "ÇIKIŞ";
            this.cikisButton2.UseVisualStyleBackColor = true;
            this.cikisButton2.Click += new System.EventHandler(this.cikisButton2_Click);
            // 
            // geriButton
            // 
            this.geriButton.Location = new System.Drawing.Point(171, 172);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(109, 23);
            this.geriButton.TabIndex = 22;
            this.geriButton.Text = "GERİ";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // sifreDegisButton
            // 
            this.sifreDegisButton.Location = new System.Drawing.Point(56, 172);
            this.sifreDegisButton.Name = "sifreDegisButton";
            this.sifreDegisButton.Size = new System.Drawing.Size(109, 23);
            this.sifreDegisButton.TabIndex = 21;
            this.sifreDegisButton.Text = "ŞİFRE DEĞİŞTİR";
            this.sifreDegisButton.UseVisualStyleBackColor = true;
            this.sifreDegisButton.Click += new System.EventHandler(this.sifreDegisButton_Click);
            // 
            // yeniSifreTextBox
            // 
            this.yeniSifreTextBox.Location = new System.Drawing.Point(227, 95);
            this.yeniSifreTextBox.Name = "yeniSifreTextBox";
            this.yeniSifreTextBox.PasswordChar = '*';
            this.yeniSifreTextBox.Size = new System.Drawing.Size(181, 20);
            this.yeniSifreTextBox.TabIndex = 20;
            this.yeniSifreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adTextBox_KeyPress);
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(227, 38);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.PasswordChar = '*';
            this.sifreTextBox.Size = new System.Drawing.Size(181, 20);
            this.sifreTextBox.TabIndex = 19;
            this.sifreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sifreTextBox_KeyPress);
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(227, 12);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(181, 20);
            this.kullaniciAdiTextBox.TabIndex = 18;
            this.kullaniciAdiTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kullaniciAdiTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Yeni Şifre :  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Şifre : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // yeniSifreTekrarTextBox
            // 
            this.yeniSifreTekrarTextBox.Location = new System.Drawing.Point(227, 121);
            this.yeniSifreTekrarTextBox.Name = "yeniSifreTekrarTextBox";
            this.yeniSifreTekrarTextBox.PasswordChar = '*';
            this.yeniSifreTekrarTextBox.Size = new System.Drawing.Size(181, 20);
            this.yeniSifreTekrarTextBox.TabIndex = 25;
            this.yeniSifreTekrarTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Yeni Şifre Tekrar :  ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 219);
            this.Controls.Add(this.yeniSifreTekrarTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cikisButton2);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.sifreDegisButton);
            this.Controls.Add(this.yeniSifreTextBox);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cikisButton2;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.Button sifreDegisButton;
        private System.Windows.Forms.TextBox yeniSifreTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yeniSifreTekrarTextBox;
        private System.Windows.Forms.Label label4;
    }
}