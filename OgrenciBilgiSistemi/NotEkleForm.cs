using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class NotEkleForm : Form
    {
        List<Ogrenci> ogrenciListesi;

        public NotEkleForm(List<Ogrenci> ogrenciler)
        {
            InitializeComponent();
            ogrenciListesi = ogrenciler;
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int no = int.Parse(txtNo.Text);
                int not = int.Parse(txtNot.Text);

                var ogr = ogrenciListesi.FirstOrDefault(o => o.ID == no);

                if (ogr != null)
                {
                    ogr.NotEkle(not);
                    MessageBox.Show("Not eklendi.");
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
