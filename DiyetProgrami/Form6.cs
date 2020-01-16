using DiyetProgrami.DAL;
using DiyetProgrami.Entity;
using DiyetProgrami.Model;
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
    public partial class Form6 : Form
    {
        DiyetisyenTbl diyetisyen;//bu formda tüm işlemler gelen diyetisyen için yapılacak gelen diyetisyenin diyetisyenTipi true ise admin olacağı için besin ve kategori ekleme yetkisi olacak.
        KisiTbl kisi;
        KisiTbl ogunIcinKisi;
        int hastaDetayIcinKisiId;//hasta detay ekleme ve güncelleme için.
        BesinTipTbl besintip;//besin tipi ekleme için
        BesinlerTbl besin2;
        BesinlerTbl besin3;
        public Form6()
        {
            InitializeComponent();
        }
        public Form6(DiyetisyenTbl diyetisyenn)
        {
            InitializeComponent();
            diyetisyen = diyetisyenn;
            if (diyetisyen.diyetisyenTipi == false)
            {
                DiyetisyenGiris();
            }
        }
        public void DiyetisyenGiris()
        {
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox12.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            groupBox23.Visible = false;
            comboBox10.SelectedIndex = 0;
            ListView6Guncelle();
            ListView3Guncelle();
            ListView2Guncelle();
            ListView1Guncelle();
            ListView5Guncelle();
            ComboBox8Guncelle();
            listView4.Items.Clear();
            ComboBox1ve2Guncelle();
            ComboBox3Guncelle();
            ComboBox5Guncelle();
            ComboBox4Guncelle();
            listView1.FullRowSelect = true;
            listView2.FullRowSelect = true;
            listView3.FullRowSelect = true;
            listView4.FullRowSelect = true;
            listView5.FullRowSelect = true;
            listView6.FullRowSelect = true;
            listView8.FullRowSelect = true;
            groupBox19.Visible = false;
            groupBox20.Visible = false;
            BesinTipiDuzenleKontrolKapat();
            YeniBesinEkleKontrolSıfırla();
            string[] fff = { "Masa baş bir işte çalışıyorum", "Az hareket ettiğim bir işte çalışıyorum", "Orta derece hareket gerektiren bir işte çalışıyorum", "Haftada en az 5 gün spor yapıyorum", "Spor müsabakasına hazırlanıyorum" };
            foreach (var item in fff)
            {
                comboBox6.Items.Add(item);
                comboBox7.Items.Add(item);
            }
        }
        public void ComboBox1ve2Guncelle()//hasta tabındaki cinsiyetleri tutan comboboxlar
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            string[] cinsiyetler = Enum.GetNames(typeof(Cinsiyet));
            foreach (var item in cinsiyetler)
            {
                comboBox1.Items.Add(item);
                comboBox2.Items.Add(item);
            }
        }
        public void ComboBox3Guncelle()//besinler tabındaki besin tipleri tutan comboboxlar
        {
            var besinTipleri = HelperBesinTip.BesinTipleri();
            comboBox3.ValueMember = "BesinTipID";
            comboBox3.DisplayMember = "BesinTipi";
            comboBox3.DataSource = besinTipleri;
        }
        public void ComboBox4Guncelle()
        {
            var besinTipleri = HelperBesinTip.BesinTipleri();
            comboBox4.ValueMember = "BesinTipID";
            comboBox4.DisplayMember = "BesinTipi";
            comboBox4.DataSource = besinTipleri;
        }
        public void ComboBox5Guncelle()
        {
            var besinTipleri = HelperBesinTip.BesinTipleri();
            comboBox5.ValueMember = "BesinTipID";
            comboBox5.DisplayMember = "BesinTipi";
            comboBox5.DataSource = besinTipleri;
        }
        public void ComboBox8Guncelle()//ogun ekleme için besintipi
        {
            var besinTipleri = HelperBesinTip.BesinTipleri();
            comboBox8.ValueMember = "BesinTipID";
            comboBox8.DisplayMember = "BesinTipi";
            comboBox8.DataSource = besinTipleri;

        }
        public void ComboBox9Guncelle(int besinTipID)//ogun ekleme için besin
        {
            var besinler = HelperBesinler.BesinTipIdyeGoreBesinListesiGetir(besinTipID);
            comboBox9.ValueMember = "BesinID";
            comboBox9.DisplayMember = "BesinAdi";
            comboBox9.DataSource = besinler;
        }
        public void ListView1Guncelle()//Hasta listesi.
        {
            listView1.Items.Clear();
            var hastaListesi = HelperKisi.KisiListele(diyetisyen.diyetisyenID);
            foreach (var item in hastaListesi)
            {
                string[] satir = { item.Adi, item.Soyadi, ((Cinsiyet)Convert.ToInt32(item.Cinsiyet)).ToString(), item.DTarihi.ToString("dd/MM/yyyy"), item.kayitTarihi.ToString("dd/MM/yyyy"), item.telefonNo, item.KisiID.ToString() };
                var yeniSatir = new ListViewItem(satir);
                listView1.Items.Add(yeniSatir);
            }
        }
        public void ListView2Guncelle()//besin listesi
        {
            listView2.Items.Clear();
            var besinListesi = HelperBesinler.BesinListele();
            foreach (var item in besinListesi)
            {
                string[] satir = { item.BesinAdi, item.BesinTipTbl.BesinTipi, item.BesinGramaj.ToString(), item.BesinKalori.ToString(), item.BesinID.ToString() };
                var yeniSatir = new ListViewItem(satir);
                listView2.Items.Add(yeniSatir);
            }
        }
        public void ListView3Guncelle()//besintipleri tabındaki besin tipleri listesi
        {
            listView3.Items.Clear();
            var besinTipListesi = HelperBesinTip.BesinTipleri();
            foreach (var item in besinTipListesi)
            {
                string[] satir = { item.BesinTipi, item.BesinTipID.ToString() };
                var yeniSatir = new ListViewItem(satir);
                listView3.Items.Add(yeniSatir);
            }
        }
        public void ListView4Guncelle(int besinTipID)//besintipleri tabındaki besinler listesi
        {
            listView4.Items.Clear();
            var list = HelperBesinler.BesinTipIdyeGoreBesinListesiGetir(besinTipID);
            foreach (var item in list)
            {
                string[] satir = { item.BesinAdi, item.BesinGramaj.ToString(), item.BesinKalori.ToString(), item.BesinID.ToString() };
                var yeniSatir = new ListViewItem(satir);
                listView4.Items.Add(yeniSatir);
            }
        }
        public void ListView5Guncelle()
        {
            listView5.Items.Clear();
            var hastaListesi = HelperKisi.KisiListele(diyetisyen.diyetisyenID);
            foreach (var item in hastaListesi)
            {
                string[] satir = { item.Adi, item.Soyadi, item.telefonNo, item.KisiID.ToString() };
                var yeniSatir = new ListViewItem(satir);
                listView5.Items.Add(yeniSatir);
            }
        }
        public void ListView6Guncelle()
        {
            listView6.Items.Clear();
            var hastaListesi = HelperKisi.KisiListele(diyetisyen.diyetisyenID);
            foreach (var item in hastaListesi)
            {
                string[] satir = { item.Adi, item.Soyadi, ((Cinsiyet)Convert.ToInt32(item.Cinsiyet)).ToString(), item.DTarihi.ToString("dd/MM/yyyy"), item.kayitTarihi.ToString("dd/MM/yyyy"), item.telefonNo, item.KisiID.ToString() };
                var yeniSatir = new ListViewItem(satir);
                listView6.Items.Add(yeniSatir);
            }
        }
        public void ListView6AramayaGoreGuncelle(string txt)
        {
            listView6.Items.Clear();
            var aramaListesi = HelperKisi.KisiListele(diyetisyen.diyetisyenID);
            foreach (var item in aramaListesi)
            {
                if ((item.Adi + " " + item.Soyadi).ToLower().Contains(txt.ToLower()))
                {
                    string[] satir = { item.Adi, item.Soyadi, ((Cinsiyet)Convert.ToInt32(item.Cinsiyet)).ToString(), item.DTarihi.ToString("dd/MM/yyyy"), item.kayitTarihi.ToString("dd/MM/yyyy"), item.telefonNo, item.KisiID.ToString() };
                    var yeniSatir = new ListViewItem(satir);
                    listView6.Items.Add(yeniSatir);
                }
            }
        }
        public void ListView8Guncelle(int kisiID)
        {
            listView8.Items.Clear();
            var ogunListesi = HelperOgun.OgunListele(kisiID);
            int genelToplamKalori = 0;
            foreach (var item in ogunListesi)
            {
                string[] satir = { item.KisiTbl.Adi, item.KisiTbl.Soyadi, item.BesinlerTbl.BesinAdi, item.BesinlerTbl.BesinGramaj.ToString(), item.BesinAdet.ToString(), item.ToplamKalori.ToString(), item.diyetProgramiTarihi.ToString("dd/MM/yyyy"), item.OgunID.ToString() };
                var yeniSatir = new ListViewItem(satir);
                listView8.Items.Add(yeniSatir);
                genelToplamKalori = genelToplamKalori + Convert.ToInt32(item.ToplamKalori);
            }
            label35.Text = "Diyet Programındaki Toplam Kalori = " + genelToplamKalori.ToString() + " kcal";
        }
        public void KisiDetayLabelSetGuncelle(int kisiID)
        {
            var kisiDetay = HelperKisiDetay.KisiIdyeGoreSonKisiDetayGetir(kisiID);
            label47.Text = (kisiDetay.Boy + " cm").ToString();
            label48.Text = (kisiDetay.Kilo + " kg").ToString();
            label49.Text = (kisiDetay.KaloriIhtiyaci + " kcal").ToString();
            label50.Text = (kisiDetay.VucutYuzeyAlani + " m²").ToString();
            label51.Text = (kisiDetay.YagsizVucutAgirligi + " kg").ToString();
            label52.Text = (kisiDetay.IdealKilo + " kg").ToString();
            label53.Text = (kisiDetay.VucutKitleIndeksi + " kg/m²").ToString();
            label54.Text = kisiDetay.bilgiGuncellemeTarihi.ToString();
            if (kisiDetay.VucutKitleIndeksi < 18.5)
            {
                label55.Text = "Hasta zayıf.Kilo alması için program yapınız.(Kalori ihtiyacından 200-300 kcal fazla almalı.)";
            }
            else if (kisiDetay.VucutKitleIndeksi >= 18.5 && kisiDetay.VucutKitleIndeksi < 24.9)
            {
                label55.Text = "Hastanın kilosu normal.(Kalori ihtiyacı kadar kalori almalı.)";
            }
            else if (kisiDetay.VucutKitleIndeksi >= 24.9 && kisiDetay.VucutKitleIndeksi < 29.9)
            {
                label55.Text = "Hasta kilolu sınıfında.(Kalori ihtiyacından 150-250 kcal fazla almalı.)";
            }
            else if (kisiDetay.VucutKitleIndeksi >= 29.9 && kisiDetay.VucutKitleIndeksi < 39.9)
            {
                label55.Text = "Hasta şişmam sınıfında.(Kalori ihtiyacından 250-400 kcal fazla almalı.)";
            }
            else if (kisiDetay.VucutKitleIndeksi >= 39.9)
            {
                label55.Text = "Hasta obez sınıfında.(Kalori ihtiyacından 500 kcal fazla almalı.)";
            }
        }
        public void ListView5AramayaGoreGuncelle(string txt)
        {
            listView5.Items.Clear();
            var aramaListesi = HelperKisi.KisiListele(diyetisyen.diyetisyenID);
            foreach (var item in aramaListesi)
            {
                if ((item.Adi + " " + item.Soyadi).ToLower().Contains(txt.ToLower()))
                {
                    string[] satir = { item.Adi, item.Soyadi, item.telefonNo, item.KisiID.ToString() };
                    var yeniSatir = new ListViewItem(satir);
                    listView5.Items.Add(yeniSatir);
                }
            }
        }
        public void HastaDuzenleKontrolAc()
        {
            textBox6.Enabled = true;
            textBox5.Enabled = true;
            comboBox2.Enabled = true;
            dateTimePicker2.Enabled = true;
            maskedTextBox2.Enabled = true;
            button4.Enabled = true;
        }
        public void HastaDuzenleKontrolKapa()
        {
            textBox6.Text = "";
            textBox5.Text = "";
            comboBox2.SelectedIndex = -1;
            dateTimePicker2.Value = DateTime.Now;
            maskedTextBox2.Text = "";
            textBox6.Enabled = false;
            textBox5.Enabled = false;
            comboBox2.Enabled = false;
            dateTimePicker2.Enabled = false;
            maskedTextBox2.Enabled = false;
            button4.Enabled = false;
        }
        public void HastaDetayEkleKontrolAc(int kisiID)
        {
            var kisi = HelperKisi.IdyeGoreKisiGetir(kisiID);
            textBox17.Enabled = true;
            textBox24.Enabled = true;
            comboBox6.Enabled = true;
            button19.Enabled = true;
            textBox20.Text = kisi.Adi;
            textBox19.Text = kisi.Soyadi;
        }
        public void HastaDetayEkleKontrolKapa()
        {
            textBox17.Enabled = false;
            textBox24.Enabled = false;
            comboBox6.Enabled = false;
            button19.Enabled = false;
            textBox20.Text = "";
            textBox19.Text = "";
            textBox17.Text = "";
            textBox24.Text = "";
            comboBox6.SelectedItem = -1;

        }
        public void HastaDetayGuncelleKontrolAc(int kisiID)
        {
            var kisi = HelperKisi.IdyeGoreKisiGetir(kisiID);
            textBox22.Enabled = true;
            textBox21.Enabled = true;
            comboBox7.Enabled = true;
            button16.Enabled = true;
            textBox25.Text = kisi.Adi;
            textBox23.Text = kisi.Soyadi;
            var sonKisi = HelperKisiDetay.KisiIdyeGoreSonKisiDetayGetir(kisiID);
            textBox22.Text = sonKisi.Boy.ToString();
            textBox21.Text = sonKisi.Kilo.ToString();
            comboBox7.SelectedIndex = Convert.ToInt32(sonKisi.CalismaBicimi);
        }
        public void HastaDetayGuncelleKontrolKapa()
        {
            textBox22.Enabled = false;
            textBox21.Enabled = false;
            comboBox7.Enabled = false;
            button16.Enabled = false;
            textBox25.Text = "";
            textBox23.Text = "";
            textBox22.Text = "";
            textBox21.Text = "";
            comboBox7.SelectedItem = -1;

        }
        private void button2_Click(object sender, EventArgs e)//hasta silme butonu
        {
            HastaDuzenleKontrolKapa();
            DialogResult dialogResult = MessageBox.Show("Bu işlem geri alınamaz.Yine de silinsin mi?", "Sil ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var ss = listView1.SelectedItems[0].SubItems[6].Text;
                    int kisiID = int.Parse(ss);
                    KisiTbl kisi = HelperKisi.IdyeGoreKisiGetir(kisiID);
                    kisi.kisiAktif = false;
                    HelperKisi.KisiCUD(kisi, System.Data.Entity.EntityState.Modified);
                    ListView1Guncelle();
                    ListView5Guncelle();
                    MessageBox.Show("Hasta Kaydı Silindi");
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen Listeden Seçim Yapınız");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)//hasta düzenleme butonu
        {

            try
            {
                var ss = listView1.SelectedItems[0].SubItems[6].Text;
                int kisiID = int.Parse(ss);
                KisiTbl kisi = HelperKisi.IdyeGoreKisiGetir(kisiID);
                textBox6.Text = kisi.Adi;
                textBox5.Text = kisi.Soyadi;
                comboBox2.Text = ((Cinsiyet)Convert.ToInt32(kisi.Cinsiyet)).ToString();
                dateTimePicker2.Value = kisi.DTarihi;
                maskedTextBox2.Text = kisi.telefonNo;
                this.kisi = kisi;
                HastaDuzenleKontrolAc();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Hasta bilgisi düzenlemek için bir hasta seçiniz");
            }
        }
        private void button4_Click(object sender, EventArgs e)//hasta düzenleme iç butonu
        {
            if (string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox5.Text) || dateTimePicker2.Value > DateTime.Now || maskedTextBox2.Text.Length != 14)//herhangi bir yanlış durumda
            {
                MessageBox.Show("Eksik veya hatalı bilgi girdiniz lütfen tekrar deneyiniz");
            }
            else
            {
                kisi.Adi = textBox6.Text;
                kisi.Soyadi = textBox5.Text;
                kisi.Cinsiyet = Convert.ToBoolean(comboBox2.SelectedIndex);
                kisi.DTarihi = dateTimePicker2.Value;
                kisi.telefonNo = maskedTextBox2.Text;
                HelperKisi.KisiCUD(kisi, System.Data.Entity.EntityState.Modified);
                MessageBox.Show("Kişi bilgileri düzenlendi");
                ListView1Guncelle();
                ListView5Guncelle();
            }
        }
        enum Cinsiyet { Kadın, Erkek }

        private void button3_Click(object sender, EventArgs e)//hasta ekleme butonu
        {
            if (comboBox1.SelectedIndex == -1 || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || dateTimePicker1.Value > DateTime.Now || maskedTextBox1.Text.Length != 14)//herhangi bir yanlış durumda
            {
                MessageBox.Show("Eksik veya hatalı bilgi girdiniz lütfen tekrar deneyiniz");
            }
            else
            {
                KisiTbl kisi = new KisiTbl();
                kisi.Adi = textBox1.Text;
                kisi.Soyadi = textBox2.Text;
                kisi.Cinsiyet = Convert.ToBoolean(comboBox1.SelectedIndex);
                kisi.DTarihi = dateTimePicker1.Value.Date;
                kisi.telefonNo = maskedTextBox1.Text;
                kisi.kayitTarihi = DateTime.Now;
                kisi.diyetisyenID = diyetisyen.diyetisyenID;
                kisi.kisiAktif = true;
                HelperKisi.KisiCUD(kisi, System.Data.Entity.EntityState.Added);
                MessageBox.Show("Yeni hasta kaydı tamamlandı");
                ListView1Guncelle();
                ListView5Guncelle();
            }
            YeniHastaEkleKontrolSifirlar();
        }
        public void YeniHastaEkleKontrolSifirlar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            maskedTextBox1.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            groupBox20.Visible = false;
            groupBox19.Visible = false;
            ListView5AramayaGoreGuncelle(textBox3.Text);
            HastaDetayGuncelleKontrolKapa();
            HastaDetayEkleKontrolKapa();
        }

        private void listView5_Click(object sender, EventArgs e)
        {
            var kisiID = listView5.SelectedItems[0].SubItems[3].Text;
            hastaDetayIcinKisiId = int.Parse(kisiID);
            bool hastaDetayVarMi = HelperKisiDetay.HastaDetayVarMi(int.Parse(kisiID));
            if (hastaDetayVarMi)//hasta detay varsa guncelleme açılacak
            {
                groupBox20.Visible = true;
                groupBox19.Visible = false;
                HastaDetayGuncelleKontrolKapa();
                HastaDetayGuncelleKontrolAc(int.Parse(kisiID));
            }
            else//hasta detay yoksa ekleme açılacak
            {
                groupBox19.Visible = true;
                groupBox20.Visible = false;
                HastaDetayEkleKontrolKapa();
                HastaDetayEkleKontrolAc(int.Parse(kisiID));
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)//tab değiştirince
        {
            groupBox20.Visible = false;
            groupBox19.Visible = false;
            listView4.Items.Clear();
            comboBox10.SelectedIndex = 0;
            ComboBox8Guncelle();
            ListView3Guncelle();
            ComboBox3Guncelle();
            ComboBox4Guncelle();
            ComboBox5Guncelle();
            ListView1Guncelle();
            ListView2Guncelle();
            ListView5Guncelle();
            ListView6Guncelle();
            HastaDetayGuncelleKontrolKapa();
            HastaDetayEkleKontrolKapa();
            HastaDuzenleKontrolKapa();
            YeniHastaEkleKontrolSifirlar();
            BesinDuzenleKontrolKapa();
            BesinDuzenleKontrolKapa2();
            YeniBesinEkleKontrolSıfırla();
            textBox15.Text = "";
            BesinTipiDuzenleKontrolKapat();
            textBox4.Text = "";
            textBox3.Text = "";
            groupBox23.Visible = false;
        }
        private void button19_Click(object sender, EventArgs e)//yeni hasta detay ekleme.(ekleme işlemi yapılacak)
        {
            KisiDetay kisiDetay = new KisiDetay();
            kisiDetay.KisiID = hastaDetayIcinKisiId;
            kisiDetay.Boy = int.Parse(textBox17.Text);
            kisiDetay.Kilo = int.Parse(textBox24.Text);
            kisiDetay.CalismaBicimi = comboBox6.SelectedIndex;
            kisiDetay.bilgiGuncellemeTarihi = DateTime.Now;
            kisiDetay.VucutKitleIndeksi = Math.Round((float)(kisiDetay.Kilo / (Math.Pow((kisiDetay.Boy * 0.01), 2))), 2);
            kisiDetay.VucutYuzeyAlani = Math.Round(0.20247 * (Math.Pow((kisiDetay.Boy * 0.01), 0.725)) * (Math.Pow(kisiDetay.Kilo, 0.425)), 2);
            var kisininKendisi = HelperKisi.IdyeGoreKisiGetir(hastaDetayIcinKisiId);
            var kisiYasi = Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(kisininKendisi.DTarihi.Year);
            double bazalMet;
            if (kisininKendisi.Cinsiyet)//erkek
            {
                kisiDetay.IdealKilo = Math.Round(50 + ((2.3 / 2.54) * (kisiDetay.Boy - 152.4)));
                kisiDetay.YagsizVucutAgirligi = Math.Round((1.10 * kisiDetay.Kilo) - (128 * (Math.Pow(kisiDetay.Kilo, 2) / Math.Pow(kisiDetay.Boy, 2))));
                bazalMet = 66 + (13.7 * kisiDetay.Kilo) + ((5 * kisiDetay.Boy) - (6.8 * kisiYasi));
            }
            else//kadın
            {
                kisiDetay.IdealKilo = Math.Round(45.5 + ((2.3 / 2.54) * (kisiDetay.Boy - 152.4)));
                kisiDetay.YagsizVucutAgirligi = Math.Round((1.07 * kisiDetay.Kilo) - (148 * (Math.Pow(kisiDetay.Kilo, 2) / Math.Pow(kisiDetay.Boy, 2))));
                bazalMet = 655 + (9.6 * kisiDetay.Kilo) + ((1.8 * kisiDetay.Boy) - (4.7 * kisiYasi));
            }
            switch (comboBox6.SelectedIndex)
            {
                case 0:
                    kisiDetay.KaloriIhtiyaci = Math.Round(bazalMet * 1.2);
                    break;
                case 1:
                    kisiDetay.KaloriIhtiyaci = Math.Round(bazalMet * 1.375);
                    break;
                case 2:
                    kisiDetay.KaloriIhtiyaci = Math.Round(bazalMet * 1.55);
                    break;
                case 3:
                    kisiDetay.KaloriIhtiyaci = Math.Round(bazalMet * 1.725);
                    break;
                case 4:
                    kisiDetay.KaloriIhtiyaci = Math.Round(bazalMet * 1.9);
                    break;
            }
            HelperKisiDetay.KisiDetayCUD(kisiDetay, System.Data.Entity.EntityState.Added);
            MessageBox.Show("Hasta Detayları Eklendi");
        }

        private void button16_Click(object sender, EventArgs e)//eski hastanın detaylarını güncelleme.(yine burada da eklem işlemi yapılacak çünkü geçmiş kayıtlardan rapor çıkartılacak)
        {
            KisiDetay kisiDetay = new KisiDetay();
            kisiDetay.KisiID = hastaDetayIcinKisiId;
            kisiDetay.Boy = int.Parse(textBox22.Text);
            kisiDetay.Kilo = int.Parse(textBox21.Text);
            kisiDetay.CalismaBicimi = comboBox7.SelectedIndex;
            kisiDetay.bilgiGuncellemeTarihi = DateTime.Now;
            kisiDetay.VucutKitleIndeksi = Math.Round((float)(kisiDetay.Kilo / (Math.Pow((kisiDetay.Boy * 0.01), 2))), 2);
            kisiDetay.VucutYuzeyAlani = Math.Round(0.20247 * (Math.Pow((kisiDetay.Boy * 0.01), 0.725)) * (Math.Pow(kisiDetay.Kilo, 0.425)), 2);
            var kisininKendisi = HelperKisi.IdyeGoreKisiGetir(hastaDetayIcinKisiId);
            var kisiYasi = Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(kisininKendisi.DTarihi.Year);
            double bazalMet;
            if (kisininKendisi.Cinsiyet)//erkek
            {
                kisiDetay.IdealKilo = Math.Round(50 + ((2.3 / 2.54) * (kisiDetay.Boy - 152.4)));
                kisiDetay.YagsizVucutAgirligi = Math.Round((1.10 * kisiDetay.Kilo) - (128 * (Math.Pow(kisiDetay.Kilo, 2) / Math.Pow(kisiDetay.Boy, 2))));
                bazalMet = 66 + (13.7 * kisiDetay.Kilo) + ((5 * kisiDetay.Boy) - (6.8 * kisiYasi));
            }
            else//kadın
            {
                kisiDetay.IdealKilo = Math.Round(45.5 + ((2.3 / 2.54) * (kisiDetay.Boy - 152.4)));
                kisiDetay.YagsizVucutAgirligi = Math.Round((1.07 * kisiDetay.Kilo) - (148 * (Math.Pow(kisiDetay.Kilo, 2) / Math.Pow(kisiDetay.Boy, 2))));
                bazalMet = 655 + (9.6 * kisiDetay.Kilo) + ((1.8 * kisiDetay.Boy) - (4.7 * kisiYasi));
            }
            switch (comboBox7.SelectedIndex)
            {
                case 0:
                    kisiDetay.KaloriIhtiyaci = Math.Round(bazalMet * 1.2);
                    break;
                case 1:
                    kisiDetay.KaloriIhtiyaci = Math.Round(bazalMet * 1.375);
                    break;
                case 2:
                    kisiDetay.KaloriIhtiyaci = Math.Round(bazalMet * 1.55);
                    break;
                case 3:
                    kisiDetay.KaloriIhtiyaci = Math.Round(bazalMet * 1.725);
                    break;
                case 4:
                    kisiDetay.KaloriIhtiyaci = Math.Round(bazalMet * 1.9);
                    break;
            }
            HelperKisiDetay.KisiDetayCUD(kisiDetay, System.Data.Entity.EntityState.Added);
            MessageBox.Show("Hasta Detayları Güncellendi");
        }


























        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)//besin silme
        {
            BesinDuzenleKontrolKapa();
            DialogResult dialogResult = MessageBox.Show("Bu işlem geri alınamaz.Yine de silinsin mi?", "Sil ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                var besinID = Convert.ToInt32(listView2.SelectedItems[0].SubItems[4].Text);
                var besin = HelperBesinler.BesinIdyeGoreBesinGetir(besinID);
                besin.besinDurum = false;
                HelperBesinler.BesinlerCUD(besin, System.Data.Entity.EntityState.Modified);
                MessageBox.Show("Besin Silindi");
                ListView2Guncelle();
            }
        }
        private void button8_Click(object sender, EventArgs e)//besin düzenleme
        {
            try
            {
                var besinID = int.Parse(listView2.SelectedItems[0].SubItems[4].Text);
                var besin = HelperBesinler.BesinIdyeGoreBesinGetir(besinID);
                this.besin2 = besin;
                BesinDuzenleKontrolAc();
                textBox12.Text = besin.BesinAdi;
                textBox11.Text = besin.BesinGramaj.ToString();
                textBox10.Text = besin.BesinKalori.ToString();
                comboBox4.Text = listView2.SelectedItems[0].SubItems[1].Text;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Lütfen listeden seçim yapınız");
            }
            ListView2Guncelle();
        }
        public void BesinDuzenleKontrolAc()
        {
            textBox12.Enabled = true;
            textBox11.Enabled = true;
            textBox10.Enabled = true;
            comboBox4.Enabled = true;
            button6.Enabled = true;
            comboBox4.SelectedIndex = 0;
        }
        public void BesinDuzenleKontrolKapa()
        {
            textBox12.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            comboBox4.SelectedIndex = 0;
            textBox12.Enabled = false;
            textBox11.Enabled = false;
            textBox10.Enabled = false;
            comboBox4.Enabled = false;
            button6.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)//besin ekle iç işlem
        {
            if (string.IsNullOrEmpty(textBox9.Text.Trim()) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox8.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurduğunuzdan emin olun");
            }
            else
            {
                BesinlerTbl besin = new BesinlerTbl();
                besin.BesinAdi = textBox9.Text.TrimStart();
                besin.besinDurum = true;
                besin.BesinGramaj = int.Parse(textBox7.Text);
                besin.BesinKalori = int.Parse(textBox8.Text);
                besin.BesinTipID = Convert.ToInt32(comboBox3.SelectedValue);
                HelperBesinler.BesinlerCUD(besin, System.Data.Entity.EntityState.Added);
                MessageBox.Show("Yeni Besin Listeye Eklendi");
                ListView2Guncelle();
                YeniBesinEkleKontrolSıfırla();
            }
        }
        public void YeniBesinEkleKontrolSıfırla()
        {
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            comboBox3.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)//besin düzenle iç işlem
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox12.Text.Trim()))
                {
                    besin2.BesinAdi = textBox12.Text.TrimStart();
                    besin2.BesinGramaj = int.Parse(textBox11.Text);
                    besin2.BesinKalori = int.Parse(textBox10.Text);
                    besin2.BesinTipID = Convert.ToInt32(comboBox4.SelectedValue);
                    HelperBesinler.BesinlerCUD(besin2, System.Data.Entity.EntityState.Modified);
                    MessageBox.Show("Besin güncelleme başarılı");
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir besin adı giriniz");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı veya eksik bilgi girmediğinizden emin olun");
            }
            ListView2Guncelle();
            BesinDuzenleKontrolKapa();
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button11_Click(object sender, EventArgs e)//besin tipleri sayfası besintipleri silme
        {
            BesinDuzenleKontrolKapa2();
            BesinTipiDuzenleKontrolKapat();
            DialogResult dialogResult = MessageBox.Show("Bu işlem geri alınamaz.Yine de silinsin mi?", "Sil ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                var besinTipID = int.Parse(listView3.SelectedItems[0].SubItems[1].Text);
                var besintip = HelperBesinTip.BesinTipIdyeGoreBesinTipGetir(besinTipID);
                besintip.besinTipDurum = false;
                HelperBesinTip.BesinTipCUD(besintip, System.Data.Entity.EntityState.Modified);
                MessageBox.Show("Besin Tipi Silindi");
                ListView3Guncelle();
            }
        }

        private void button9_Click(object sender, EventArgs e)//yeni besintipi ekle
        {
            BesinDuzenleKontrolKapa2();
            BesinTipiDuzenleKontrolKapat();
            if (!string.IsNullOrEmpty(textBox15.Text))
            {
                BesinTipTbl besinTipi = new BesinTipTbl();
                besinTipi.BesinTipi = textBox15.Text;
                besinTipi.besinTipDurum = true;
                HelperBesinTip.BesinTipCUD(besinTipi, System.Data.Entity.EntityState.Added);
                MessageBox.Show("Yeni besin tipi eklendi");
                ListView3Guncelle();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli besin tipi girdiğinizden emin olun.");
            }

        }


        private void listView3_Click(object sender, EventArgs e)
        {
            var besinTipID = int.Parse(listView3.SelectedItems[0].SubItems[1].Text);
            ListView4Guncelle(besinTipID);
        }

        private void button14_Click(object sender, EventArgs e)//besintipleri tablosu besinler silme buton
        {
            BesinDuzenleKontrolKapa2();
            BesinTipiDuzenleKontrolKapat();
            BesinDuzenleKontrolKapa2();
            DialogResult dialogResult = MessageBox.Show("Bu işlem geri alınamaz.Yine de silinsin mi?", "Sil ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                var besinID = Convert.ToInt32(listView4.SelectedItems[0].SubItems[3].Text);
                var besin = HelperBesinler.BesinIdyeGoreBesinGetir(besinID);
                besin.besinDurum = false;
                HelperBesinler.BesinlerCUD(besin, System.Data.Entity.EntityState.Modified);
                MessageBox.Show("Besin Silindi");
                var besinTipID = int.Parse(listView3.SelectedItems[0].SubItems[1].Text);
                ListView4Guncelle(besinTipID);
            }
        }

        private void button15_Click(object sender, EventArgs e)//besintipleri düzenle dış buton
        {
            BesinTipiDuzenleKontrolKapat();
            try
            {
                var besinID = int.Parse(listView4.SelectedItems[0].SubItems[3].Text);
                var besin = HelperBesinler.BesinIdyeGoreBesinGetir(besinID);
                var besinTip = HelperBesinler.BesinIdyeGoreBesinTipGetir(besinID);
                this.besin3 = besin;
                BesinDuzenleKontrolAc2();
                textBox16.Text = besin.BesinAdi;
                textBox14.Text = besin.BesinGramaj.ToString();
                textBox13.Text = besin.BesinKalori.ToString();
                comboBox5.Text = besinTip;
                ListView4Guncelle(besin3.BesinTipID);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Lütfen listeden seçim yapınız");
            }
            ListView2Guncelle();
        }
        public void BesinDuzenleKontrolAc2()
        {
            textBox16.Enabled = true;
            textBox14.Enabled = true;
            textBox13.Enabled = true;
            comboBox5.Enabled = true;
            button13.Enabled = true;
            comboBox5.SelectedIndex = 0;
        }
        public void BesinDuzenleKontrolKapa2()
        {
            textBox16.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
            comboBox5.SelectedIndex = 0;
            textBox16.Enabled = false;
            textBox14.Enabled = false;
            textBox13.Enabled = false;
            comboBox5.Enabled = false;
            button13.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)//besintipleri tabı besin düzenleme iç button
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox16.Text.Trim()))
                {
                    besin3.BesinAdi = textBox16.Text.TrimStart();
                    besin3.BesinGramaj = int.Parse(textBox14.Text);
                    besin3.BesinKalori = int.Parse(textBox13.Text);
                    besin3.BesinTipID = Convert.ToInt32(comboBox5.SelectedValue);
                    HelperBesinler.BesinlerCUD(besin3, System.Data.Entity.EntityState.Modified);
                    MessageBox.Show("Besin güncelleme başarılı");
                    BesinDuzenleKontrolKapa2();
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir besin adı giriniz");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı veya eksik bilgi girmediğinizden emin olun");
            }
            finally
            {
                var besinTipID = int.Parse(listView3.SelectedItems[0].SubItems[1].Text);
                ListView4Guncelle(besinTipID);
            }
            BesinDuzenleKontrolKapa2();
            BesinTipiDuzenleKontrolKapat();
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)//besintipduzenle dış buton
        {
            BesinDuzenleKontrolKapa2();
            try
            {
                var besinTipId = int.Parse(listView3.SelectedItems[0].SubItems[1].Text);
                textBox18.Enabled = true;
                button10.Enabled = true;
                var besinTip = HelperBesinTip.BesinTipIdyeGoreBesinTipGetir(besinTipId);
                textBox18.Text = besinTip.BesinTipi;
                this.besintip = besinTip;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Besin Tipi Seçiniz");
            }
        }
        private void button10_Click(object sender, EventArgs e)//besintipduzenle iç buton
        {
            BesinDuzenleKontrolKapa2();
            if (!string.IsNullOrEmpty(textBox18.Text))
            {
                besintip.BesinTipi = textBox18.Text;
                HelperBesinTip.BesinTipCUD(besintip, System.Data.Entity.EntityState.Modified);
            }
            else
            {
                MessageBox.Show("Eksik ya da hatalı bilgi girdiniz");
            }
            ListView3Guncelle();
        }
        public void BesinTipiDuzenleKontrolKapat()
        {
            textBox18.Enabled = false;
            textBox18.Text = "";
            button10.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ListView6AramayaGoreGuncelle(textBox4.Text);
        }

        private void button17_Click(object sender, EventArgs e)//ogun ekle btn dış
        {
            label55.Text = "";
            comboBox8.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;
            try
            {
                var kisiID = int.Parse(listView6.SelectedItems[0].SubItems[6].Text);
                var kisi = HelperKisi.IdyeGoreKisiGetir(kisiID);
                ogunIcinKisi = kisi;
                ListView8Guncelle(ogunIcinKisi.KisiID);
                KisiDetayLabelSetGuncelle(ogunIcinKisi.KisiID);
                groupBox23.Visible = true;
            }
            catch (Exception hata)
            {
                if (hata.Message == "InvalidArgument='0' değeri 'index' için geçerli değil.\r\nParametre adı: index")
                {
                    MessageBox.Show("Lütfen Listeden Seçim Yapınız");
                    groupBox23.Visible = false;
                }
                else if (hata.Message == "Nesne başvurusu bir nesnenin örneğine ayarlanmadı.")
                {
                    MessageBox.Show("Lütfen Seçtiğiniz Hastanın Detay Bilgilerini Ekleyiniz.");
                    groupBox23.Visible = false;
                }
            }
        }

        private void listView6_MouseClick(object sender, MouseEventArgs e)
        {
            groupBox23.Visible = false;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            var besinTipId = Convert.ToInt32(comboBox8.SelectedValue);
            ComboBox9Guncelle(besinTipId);
        }

        private void button20_Click(object sender, EventArgs e)//diyet programına ekleme yapma.(ogun ekleme)
        {
            OgunTbl ogun = new OgunTbl();
            ogun.KisiID = ogunIcinKisi.KisiID;
            ogun.BesinID = Convert.ToInt32(comboBox9.SelectedValue);
            ogun.BesinAdet = Convert.ToInt32(comboBox10.Text);
            ogun.diyetProgramiTarihi = DateTime.Now.Date;
            ogun.ogunDurum = true;
            HelperOgun.OgunCUD(ogun, System.Data.Entity.EntityState.Added);
            ListView8Guncelle(ogunIcinKisi.KisiID);
        }

        private void button21_Click(object sender, EventArgs e)//secili olan ogunu silme
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bu işlem geri alınamaz.Yine de silinsin mi?", "Sil ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int ogunID = int.Parse(listView8.SelectedItems[0].SubItems[7].Text);
                    var ogun = HelperOgun.OgunIdyeGoreOgunGetir(ogunID);
                    ogun.ogunDurum = false;
                    HelperOgun.OgunCUD(ogun, System.Data.Entity.EntityState.Modified);
                    ListView8Guncelle(ogunIcinKisi.KisiID);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Öğünü Seçiniz.");
            }
        }
    }
}
