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
    public partial class Menu : Form
    {
        List<Ogrenci> ogrenciListesi = new List<Ogrenci>();

        public Menu()
        {
            InitializeComponent();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ogrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OgrenciEkleForm ekleForm = new OgrenciEkleForm(ogrenciListesi);
            ekleForm.Show();


        }

        private void ogrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciSilForm silForm = new OgrenciSilForm(ogrenciListesi);
            silForm.Show();

        }

        private void ogrencileriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NotEkleForm notForm = new NotEkleForm(ogrenciListesi);
            notForm.Show();

        }

        private void notSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrtalamaForm ortalamaForm = new OrtalamaForm(ogrenciListesi);
            ortalamaForm.Show();
        }


        private void notlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotListeleForm listeleForm = new NotListeleForm(ogrenciListesi);
            listeleForm.Show();
        }




        private void Menu_Load(object sender, EventArgs e)
        {

        }




        private void ekleButton_Click(object sender, EventArgs e)
        {



        }

        private void adLabel1_Click(object sender, EventArgs e)
        {

        }

        private void adBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}