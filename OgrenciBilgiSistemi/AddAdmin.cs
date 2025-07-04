using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text.Trim();
            string sifre = textBox2.Text.Trim();

            using (var db = new OBSContext())
            {
                var yeniAdmin = new Admin(kullaniciAdi, sifre);
                db.Adminler.Add(yeniAdmin);
                int sonuc = db.SaveChanges();
                MessageBox.Show($"{sonuc} kayıt eklendi.");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
