using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class OgrencileriListele : Form
    {
        public OgrencileriListele()
        {
            InitializeComponent();
            this.Load += OgrencileriListele_Load;
        }

        private void OgrencileriListele_Load(object sender, EventArgs e)
        {
            
                using (var context = new OBSContext())
                {
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    var ogrenciler = context.Ogrenciler
                        .Include(o => o.Notlar)
                        .Select(o => new
                        {
                            o.Id,
                            o.OgrenciNo,
                            o.Isim,
                            o.Soyisim,
                            Notlar = string.Join(", ", o.Notlar.Select(n => n.Deger.ToString()))
                        })
                        .ToList();

                    dataGridView1.DataSource = ogrenciler;
                }
            }        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
