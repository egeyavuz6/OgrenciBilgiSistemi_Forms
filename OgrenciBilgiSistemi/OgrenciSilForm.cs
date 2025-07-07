using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class OgrenciSilForm : Form
    {
        List<Ogrenci> ogrenciListesi;

        public OgrenciSilForm(List<Ogrenci> ogrenciler)
        {
            InitializeComponent();
            ogrenciListesi = ogrenciler;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string ogrenciNo = textBox1.Text.Trim();


            if (string.IsNullOrEmpty(ogrenciNo))
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = "Please Enter a Student Number!",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                }.Show();
                return;
            }

             using (var context = new OBSContext())
                {
                    var ogrenci = context.Ogrenciler.FirstOrDefault(o => o.OgrenciNo == ogrenciNo);

                    if (ogrenci != null)
                    {
                        context.Ogrenciler.Remove(ogrenci);
                        context.SaveChanges();

                        new Guna2MessageDialog
                        {
                            Caption = "Successful",
                            Text = "Student Deleted Successfully",
                            Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                            Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                            Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                        }.Show();
                    }
                    else
                    {
                        new Guna2MessageDialog
                        {
                            Caption = "Error!",
                            Text = "Cannot Found The Student!",
                            Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                            Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                            Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                        }.Show();
                    }
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

