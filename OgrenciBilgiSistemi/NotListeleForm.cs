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
                var ogr = ogrenciListesi.FirstOrDefault(o => o.ID == no);

                if (ogr != null)
                {
                    if (ogr.notlar.Count > 0)
                    {
                        string notlar = string.Join(", ", ogr.notlar);
                        MessageBox.Show("Öğrenci: " + ogr.isim + " " + ogr.soyisim+" \n\nÖğrencinin Notları: " + notlar);
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
