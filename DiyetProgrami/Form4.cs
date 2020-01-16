using DiyetProgrami.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetProgrami
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void cikisButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kullaniciAdiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void sifreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void adTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void sifreDegisButton_Click(object sender, EventArgs e)
        {
            if (kullaniciAdiTextBox.Text == "" || sifreTextBox.Text == "" || yeniSifreTextBox.Text == "" || yeniSifreTekrarTextBox.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuzdan Emin Olun", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!HelperDiyetisyen.DiyetisyenAdıKontrolEt(kullaniciAdiTextBox.Text))
            {
                MessageBox.Show("Böyle Bir Kullanıcı Mevcut Değil","Hatalı Kullanıcı Adı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (!HelperDiyetisyen.DiyetisyenIdPassUyuyorMu(kullaniciAdiTextBox.Text,sifreTextBox.Text))
            {
                MessageBox.Show("Kullanıcı Adı ve Şifreniz Uyuşmamakta.");
            }
            else if (yeniSifreTextBox.Text!=yeniSifreTekrarTextBox.Text)
            {
                MessageBox.Show("Lütfen Yeni Şifrelerinizi Aynı Giriniz", "Şifre Uyuşmazlığı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var diyetisyen=HelperDiyetisyen.GirisYap(kullaniciAdiTextBox.Text, sifreTextBox.Text);
                diyetisyen.diyetisyenSifre = yeniSifreTextBox.Text;
                HelperDiyetisyen.DiyetisyenCUD(diyetisyen, System.Data.Entity.EntityState.Modified);
                MessageBox.Show("Şifreniz Değiştirildi", "Şifre Değişikliği", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
