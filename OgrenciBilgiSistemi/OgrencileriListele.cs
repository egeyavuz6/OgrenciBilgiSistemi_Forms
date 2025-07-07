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
    public partial class OgrencileriListele : Form
    {
        public OgrencileriListele()
        {
            InitializeComponent();

            this.Load += OgrencileriListele_Load;  
        }
        private void OgrencileriListele_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new OBSContext())
                {
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
 
                    var ogrenciler = context.Ogrenciler.ToList();
                    dataGridView1.DataSource = ogrenciler;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
