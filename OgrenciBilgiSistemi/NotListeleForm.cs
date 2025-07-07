using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class NotListeleForm : Form
    {
        private DataGridView dataGridView1;
        private List<Ogrenci> ogrenciListesi;
        private OBSContext db;  

        public NotListeleForm(List<Ogrenci> ogrenciler, OBSContext dbContext)   
        {
            InitializeComponent();
            ogrenciListesi = ogrenciler;
            db = dbContext; 

            dataGridView1 = new DataGridView
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(dataGridView1);
        }

        private void btnListele_Click_1(object sender, EventArgs e)
        {
            string ogrenciNo = txtNo.Text.Trim();
            if (string.IsNullOrEmpty(ogrenciNo))
            {
                MessageBox.Show("Lütfen öğrenci numarasını giriniz.");
                return;
            }

            // Öğrenciyi veritabanından OgrenciNo ile bul
            var ogrenci = db.Ogrenciler.FirstOrDefault(o => o.OgrenciNo == ogrenciNo);
            if (ogrenci == null)
            {
                MessageBox.Show("Öğrenci bulunamadı.");
                return;
            }

            // Notları veritabanından çek
            var notlar = db.Notlar
                .Where(n => n.OgrenciId == ogrenci.Id)
                .ToList();

            if (notlar == null || notlar.Count == 0)
            {
                MessageBox.Show("Bu öğrencinin notu bulunmamaktadır.");
                return;
            }

            dataGridView1.DataSource = notlar.Select(n => new
            {
                n.Deger,
                OgrenciNo = ogrenci.OgrenciNo,
                OgrenciIsim = ogrenci.Isim,
                OgrenciSoyisim = ogrenci.Soyisim
            }).ToList();
        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
