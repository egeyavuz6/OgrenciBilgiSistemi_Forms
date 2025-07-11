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
            try 
            { 
            
                using (var context = new OBSContext())
                {
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.BackgroundColor = Color.FromArgb(44, 47, 51);

                    var ogrenciler = context.Ogrenciler
                        .Select(o => new
                        {
                            o.Isim,
                            o.Soyisim,
                            o.OgrenciNo,
                            
                        })
                        .ToList();

                    dataGridView1.DataSource = ogrenciler;
                }
                dataGridView1.Columns[0].HeaderText = "Name";
                dataGridView1.Columns[1].HeaderText = "Last Name";
                dataGridView1.Columns[2].HeaderText = "Student Number";
            }
            catch (Exception ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = $"An error occurred: {ex.Message}",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
                }.Show();

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
