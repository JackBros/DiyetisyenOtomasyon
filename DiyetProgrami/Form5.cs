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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cikisButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void girisBtn_Click(object sender, EventArgs e)//giris butonu
        {
            string diyetisyenAdi = kullaniciAdiTextBox.Text;
            string sifre = sifreTextBox.Text;
            var diyetisyen = HelperDiyetisyen.GirisYap(diyetisyenAdi, sifre);
            if (kullaniciAdiTextBox.Text == "" || sifreTextBox.Text == "")
            {
                MessageBox.Show("Tüm Alanları Doldurduğunuzdan Emin Olun");
            }
            else if (diyetisyen == null)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı.");
            }
            else if(diyetisyen.diyetisyenTipi==true)
            {
                MessageBox.Show("Admin olarak giriş yapıldı");
                Form6 f = new Form6(diyetisyen);
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Diyetisyen olarak giriş yapıldı");
                Form6 f = new Form6(diyetisyen);
                this.Hide();
                f.ShowDialog();
            }
            kullaniciAdiTextBox.Text = "";
            sifreTextBox.Text = "";
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

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
