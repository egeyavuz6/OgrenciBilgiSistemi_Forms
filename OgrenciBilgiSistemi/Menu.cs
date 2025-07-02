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
            adLabel1.Visible = true;
            adBox1.Visible = true;
            soyadLabel.Visible = true;
            soyadBox1.Visible = true;
            noLabel.Visible = true;
            noBox.Visible = true;
            Button.Visible = true;
            Button.Text = "Öğrenci Ekle";
        }

        private void ogrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noLabel.Visible = true;
            noBox.Visible = true;
            Button.Visible = true;
            Button.Text = "Öğrenci Sil";

        }

        private void ogrencileriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noLabel.Visible = true;
            noBox.Visible = true;
            Button.Visible = true;
            Button.Text = "Not Ekle";
        }

        private void notSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noLabel.Visible = true;
            noBox.Visible = true;
            Button.Visible = true;
            Button.Text = "Ortalama Al";
        }

        private void notlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noLabel.Visible = true;
            noBox.Visible = true;
            Button.Text = "Notları Listele";
            Button.Visible = true;
        }



        private void Menu_Load(object sender, EventArgs e)
        {

        }

        

        private void ekleButton_Click(object sender, EventArgs e)
        {
            switch (Button.Text)
            {
                case "Öğrenci Ekle":
                    adBox1.Visible = false;
                    soyadBox1.Visible = false;
                    noBox.Visible = false;
                    adLabel1.Visible = false;
                    soyadLabel.Visible = false;
                    noLabel.Visible = false;
                    Button.Visible = false;

                    MessageBox.Show("Öğrenci eklendi: " + adBox1.Text + " " + soyadBox1.Text);
                    break;
                case "Öğrenci Sil":
                    noBox.Visible = false;
                    noLabel.Visible = false;
                    Button.Visible = false;

                    MessageBox.Show("Öğrenci silindi: " + noBox.Text);
                    break;
                case "Not Ekle":
                    noBox.Visible = false;
                    noLabel.Visible = false;
                    Button.Visible = false;

                    MessageBox.Show("Not eklendi: " + noBox.Text);
                    break;
                case "Ortalama Al":
                    noBox.Visible = false;
                    noLabel.Visible = false;
                    Button.Visible = false;
                    break;

                case "Notları Listele":
                    noBox.Visible = false;
                    noLabel.Visible = false;
                    Button.Visible = false;
                    break;
            }
        }

    }
}