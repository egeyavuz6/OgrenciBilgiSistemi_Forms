using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class OgrenciSilForm : Form
    {
        List<Ogrenci> ogrenciListesi;

        public OgrenciSilForm(List<Ogrenci> ogrenciler)
        {
            InitializeComponent();
            ogrenciListesi = ogrenciler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int no = int.Parse(textBox1.Text);
                var silinecek = ogrenciListesi.FirstOrDefault(o => o.ID == no);

                if (silinecek != null)
                {
                    ogrenciListesi.Remove(silinecek);
                    MessageBox.Show("Öğrenci silindi: " + silinecek.isim + " " + silinecek.soyisim);
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
