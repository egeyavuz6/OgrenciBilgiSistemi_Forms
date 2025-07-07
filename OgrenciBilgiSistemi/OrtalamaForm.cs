using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class OrtalamaForm : Form
    {
        private OBSContext db;

        public OrtalamaForm(OBSContext dbContext)
        {
            InitializeComponent();
            db = dbContext;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ogrenciNo = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(ogrenciNo))
            {
                MessageBox.Show("Lütfen öğrenci numarasını giriniz.");
                return;
            }

            var ogrenci = db.Ogrenciler.Include(o => o.Notlar).FirstOrDefault(o => o.OgrenciNo == ogrenciNo);

            if (ogrenci == null)
            {
                MessageBox.Show("Öğrenci bulunamadı.");
                return;
            }

            if (ogrenci.Notlar == null || ogrenci.Notlar.Count == 0)
            {
                MessageBox.Show("Bu öğrencinin notu bulunmamaktadır.");
                return;
            }

            double ortalama = ogrenci.Notlar.Average(n => n.Deger);
            MessageBox.Show($"Ortalama: {ortalama:F2}");  
        }
    }
}
