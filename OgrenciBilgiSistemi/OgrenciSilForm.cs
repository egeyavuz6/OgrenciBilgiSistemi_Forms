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

            string ogrenciNo = textBox1.Text.Trim(); 


            if (string.IsNullOrEmpty(ogrenciNo))
            {
                MessageBox.Show("Lütfen öğrenci numarasını girin.");
                return;
            }

            try
            {
                using (var context = new OBSContext())
                {
                    var ogrenci = context.Ogrenciler.FirstOrDefault(o => o.OgrenciNo == ogrenciNo);

                    if (ogrenci != null)
                    {
                        context.Ogrenciler.Remove(ogrenci);
                        context.SaveChanges();

                        MessageBox.Show("Öğrenci başarıyla silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bulunamadı.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

    }
}

