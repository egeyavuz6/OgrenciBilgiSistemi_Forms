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
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ogrenciNo = txtNo.Text.Trim();
            string isim = txtAd.Text.Trim();
            string soyisim = txtSoyad.Text.Trim();

            if (string.IsNullOrEmpty(ogrenciNo) || string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(soyisim))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            using (var db = new OBSContext())
            {
                if (db.Ogrenciler.Any(o => o.OgrenciNo == ogrenciNo))
                {
                    MessageBox.Show("Bu öğrenci numarası zaten kullanılıyor.");
                    return;
                }

                var yeniOgrenci = new Ogrenci
                {
                    OgrenciNo = ogrenciNo,
                    Isim = isim,
                    Soyisim = soyisim
                };

                db.Ogrenciler.Add(yeniOgrenci);
                db.SaveChanges();
                MessageBox.Show("Öğrenci başarıyla eklendi!");
                this.Close();
            }

        }

    }
}
