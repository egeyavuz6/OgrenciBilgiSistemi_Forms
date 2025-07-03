using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class OgrenciEkleForm : Form
    {
        List<Ogrenci> ogrenciListesi;

        public OgrenciEkleForm(List<Ogrenci> ogrenciler)
        {
            InitializeComponent();
            ogrenciListesi = ogrenciler;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(txtNo.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                if (txtAd.Text.Any(char.IsDigit) || txtSoyad.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Ad ve soyad alanları sadece harf içermelidir.");
                    return;
                }

                if (!int.TryParse(txtNo.Text, out int ogrenciNo) || ogrenciNo < 0)
                {
                    MessageBox.Show("Öğrenci numarası pozitif bir sayı olmalıdır.");
                    return;
                }
                if (ogrenciListesi.Exists(o => o.ID == ogrenciNo))
                {
                    MessageBox.Show("Bu öğrenci numarası zaten mevcut.");
                    return;

                }

                Ogrenci yeniOgrenci = new Ogrenci()
                {
                    isim = txtAd.Text,
                    soyisim = txtSoyad.Text,
                    ID = ogrenciNo
                };

                ogrenciListesi.Add(yeniOgrenci);
                MessageBox.Show("Öğrenci eklendi: " + yeniOgrenci.isim + " " + yeniOgrenci.soyisim);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş yaptın, tekrar dene.");
            }

        }
    }
}
