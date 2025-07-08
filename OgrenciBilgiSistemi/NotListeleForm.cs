using Guna.UI2.WinForms;
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
            dataGridView1.Visible = false;
        }


        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {

                string ogrenciNo = txtNo.Text.Trim();
                if (string.IsNullOrEmpty(ogrenciNo))
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Please Fill The Student Number",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                        Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                    }.Show();
                    return;
                }

                var ogrenci = db.Ogrenciler.FirstOrDefault(o => o.OgrenciNo == ogrenciNo);
                if (ogrenci == null)
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Student Doesn't Exist",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                        Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                    }.Show();
                    return;
                }

                var notlar = db.Notlar
                    .Where(n => n.OgrenciId == ogrenci.Id)
                    .ToList();

                if (notlar == null || notlar.Count == 0)
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "This Student Doesn't Have Any Grade!",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                        Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                    }.Show();
                    return;
                }
                dataGridView1.Visible = true;
                dataGridView1.BackgroundColor = Color.FromArgb(44, 47, 51);
                dataGridView1.DataSource = notlar.Select(n => new
                {
                    n.Deger,
                    OgrenciNo = ogrenci.OgrenciNo,
                    OgrenciIsim = ogrenci.Isim,
                    OgrenciSoyisim = ogrenci.Soyisim
                }).ToList();
            }
            catch (Exception ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = $"An error occurred: {ex.Message}",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light
                }.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
