using Microsoft.EntityFrameworkCore;
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



        private void NotEkleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNotEkle_Click_1(object sender, EventArgs e)
        {
            string ogrenciNo = txtNo.Text.Trim();
            string grade = txtNot.Text.Trim();
            if (string.IsNullOrEmpty(ogrenciNo) || string.IsNullOrEmpty(grade))
                        {
                            MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                            return;
                        }
            using (var db = new OBSContext())
                {
                var ogrenci = db.Ogrenciler.Include(o => o.Notlar).FirstOrDefault(o => o.OgrenciNo == ogrenciNo);
                if (ogrenci == null)
                {
                    MessageBox.Show("Öğrenci bulunamadı.");
                    return;
                }
                if (!double.TryParse(grade, out double notDegeri))
                {
                    MessageBox.Show("Lütfen geçerli bir not giriniz.");
                    return;
                }
                if (notDegeri < 0 || notDegeri > 100)
                {
                    MessageBox.Show("Not 0 ile 100 arasında olmalıdır.");
                    return;
                }
                ogrenci.NotEkle(notDegeri);
                db.SaveChanges();
                MessageBox.Show("Not başarıyla eklendi!");
                txtNot.Clear();
            }

        }

        private void txtNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNot_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
