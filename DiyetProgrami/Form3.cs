using DiyetProgrami.DAL;
using DiyetProgrami.Entity;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void CikisButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void GeriButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uyeOlButton_Click(object sender, EventArgs e)
        {
            if (kullaniciAdiTxtBox.Text == "" || sifreTxtBox.Text == "" || sifreTekrarTxtBox.Text=="")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurduğunuzdan Emin Olun","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (HelperDiyetisyen.DiyetisyenAdıKontrolEt(kullaniciAdiTxtBox.Text))
            {
                MessageBox.Show("Lütfen Farklı Bir Kullanıcı Adı Giriniz","Bu Kullanıcı Adı Zaten Alınmış",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (sifreTxtBox.Text==sifreTekrarTxtBox.Text)
            {
                DiyetisyenTbl yeniDiyetisyen = new DiyetisyenTbl();
                yeniDiyetisyen.diyetisyenAdi = kullaniciAdiTxtBox.Text;
                yeniDiyetisyen.diyetisyenSifre = sifreTxtBox.Text;
                yeniDiyetisyen.diyetisyenTipi = false;
                HelperDiyetisyen.DiyetisyenCUD(yeniDiyetisyen, System.Data.Entity.EntityState.Added);
                MessageBox.Show("Kayıt İşlemi Başarılı","Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Şifreleri Aynı Giriniz","Şifre Uyuşmazlığı!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void kullaniciAdiTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar==32)
            {
                e.Handled = true;
            }
        }

        private void sifreTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void sifreTekrarTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
    }
}
