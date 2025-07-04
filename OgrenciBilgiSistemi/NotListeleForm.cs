using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class NotListeleForm : Form
    {
        List<Ogrenci> ogrenciListesi;

        public NotListeleForm(List<Ogrenci> ogrenciler)
        {
            InitializeComponent();
            ogrenciListesi = ogrenciler;
        }

        private void btnListele_Click_1(object sender, EventArgs e)
        {
            try
            {
                int no = int.Parse(txtNo.Text);
                var ogr = ogrenciListesi.FirstOrDefault(o => o.Id == no);

                if (ogr != null)
                {
                    if (ogr.Notlar.Count > 0)
                    {
                        string notlar = string.Join(", ", ogr.Notlar);
                        MessageBox.Show("Öğrenci: " + ogr.Isim + " " + ogr.Soyisim+" \n\nÖğrencinin Notları: " + notlar);
                    }
                    else
                    {
                        MessageBox.Show("Bu öğrencinin notu yok.");
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Geçersiz giriş yaptın, tekrar dene.");
            }
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
