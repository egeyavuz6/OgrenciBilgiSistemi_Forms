using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class OrtalamaForm : Form
    {
        List<Ogrenci> ogrenciListesi;

        public OrtalamaForm(List<Ogrenci> ogrenciler)
        {
            InitializeComponent();
            ogrenciListesi = ogrenciler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int no = int.Parse(textBox1.Text);
                var ogr = ogrenciListesi.FirstOrDefault(o => o.ID == no);

                if (ogr != null)
                {
                    double ortalama = ogr.OrtalamaHesapla();
                    MessageBox.Show("Öğrencinin Ortalaması: " + ortalama);
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
    }
}
