using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class NotSilForm : Form
    {
        private OBSContext db;

        public NotSilForm(List<Ogrenci> ogrenciler, OBSContext dbContext)
        {
            InitializeComponent();
            db = dbContext;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            
        }


        private void btnSil_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
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

            dataGridView1.DataSource = ogrenci.Notlar.Select(n => new
            {
                n.Id,
                n.Deger
            }).ToList();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz notu seçiniz.");
                return;
            }

            int notId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            var not = db.Notlar.FirstOrDefault(n => n.Id == notId);
            if (not == null)
            {
                MessageBox.Show("Not bulunamadı.");
                return;
            }

            db.Notlar.Remove(not);
            db.SaveChanges();
            MessageBox.Show("Not başarıyla silindi.");

            btnSil_Click_1(null, null);
        }
    }
}
