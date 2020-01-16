namespace DiyetProgrami
{
    partial class Form5
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
            this.girisBtn = new System.Windows.Forms.Button();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cikisButton2
            // 
            this.cikisButton2.Location = new System.Drawing.Point(242, 78);
            this.cikisButton2.Name = "cikisButton2";
            this.cikisButton2.Size = new System.Drawing.Size(109, 23);
            this.cikisButton2.TabIndex = 34;
            this.cikisButton2.Text = "ÇIKIŞ";
            this.cikisButton2.UseVisualStyleBackColor = true;
            this.cikisButton2.Click += new System.EventHandler(this.cikisButton2_Click);
            // 
            // geriButton
            // 
            this.geriButton.Location = new System.Drawing.Point(127, 78);
            this.geriButton.Name = "geriButton";
            this.geriButton.Size = new System.Drawing.Size(109, 23);
            this.geriButton.TabIndex = 33;
            this.geriButton.Text = "GERİ";
            this.geriButton.UseVisualStyleBackColor = true;
            this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(12, 78);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(109, 23);
            this.girisBtn.TabIndex = 32;
            this.girisBtn.Text = "GİRİŞ";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(174, 38);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.PasswordChar = '*';
            this.sifreTextBox.Size = new System.Drawing.Size(181, 20);
            this.sifreTextBox.TabIndex = 30;
            this.sifreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sifreTextBox_KeyPress);
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(174, 12);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(181, 20);
            this.kullaniciAdiTextBox.TabIndex = 29;
            this.kullaniciAdiTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kullaniciAdiTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Şifre : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 121);
            this.Controls.Add(this.cikisButton2);
            this.Controls.Add(this.geriButton);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cikisButton2;
        private System.Windows.Forms.Button geriButton;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}