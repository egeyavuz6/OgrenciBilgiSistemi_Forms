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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Ogrenci yeniOgrenci = new Ogrenci()
                {
                    isim = txtAd.Text,
                    soyisim = txtSoyad.Text,
                    ID = int.Parse(txtNo.Text)
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
