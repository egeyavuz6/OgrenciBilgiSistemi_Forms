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
            try
            {
                int no = int.Parse(txtNo.Text);
                double not = double.Parse(txtNot.Text);

                if (not < 0 || not > 100)
                {
                    MessageBox.Show("Not 0 ile 100 arasında olmalıdır.");
                    return;
                }

                using (var db = new OBSContext())
                {
                    var ogr = db.Ogrenciler.Include(o => o.Notlar).FirstOrDefault(o => o.Id == no);

                    if (ogr != null)
                    {
                        ogr.NotEkle(not);
                        db.SaveChanges();
                        MessageBox.Show("Not eklendi.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bulunamadı.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Geçersiz giriş yaptın, tekrar dene.");
            }
        }

    }
}
