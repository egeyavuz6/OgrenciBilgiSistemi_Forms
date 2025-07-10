using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class OgrenciEkleForm : Form
    {
        List<Ogrenci> ogrenciListesi;
        private OBSContext db;

        public OgrenciEkleForm(List<Ogrenci> ogrenciler, OBSContext dbContext)
        {
            InitializeComponent();
            ogrenciListesi = ogrenciler;
            db = dbContext;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Regex regex = new Regex("^[a-zA-ZçÇğĞıİöÖşŞüÜ\\s]{2,50}$");
                string ogrenciNo = txtNo.Text.Trim();
                string isim = txtAd.Text.Trim();
                string soyisim = txtSoyad.Text.Trim();
                string sifre = passwordBox.Text.Trim();

                if (string.IsNullOrEmpty(ogrenciNo) || string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(soyisim))
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Please Fill All of Them",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,

                    }.Show();
                    return;
                }
                if (!regex.IsMatch(isim))
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Name Can Only Contain Letters!",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    }.Show();
                    return;
                }
                if (!regex.IsMatch(soyisim))
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Surname Can Only Contain Letters!",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    }.Show();
                    return;
                }
                //isim veya soyisim sayı olamaz
                if (string.Format("{0}", isim).Any(char.IsDigit) || string.Format("{0}", soyisim).Any(char.IsDigit))
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "You Cannot Enter an Integer to name or surname!",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,

                    }.Show();
                    return;
                }
                //ogrenciNo sadece rakamlardan oluşmalı
                if (!int.TryParse(ogrenciNo, out _))
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Student Number Must Be Numeric!",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    }.Show();
                    return;
                }
                //ogrenciNo 0 dan büyük olmalı
                if (int.Parse(ogrenciNo) <= 0)
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Student Number Must Be Greater Than 0!",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    }.Show();
                    return;
                }


                using (var db = new OBSContext())
                {
                    if (db.Ogrenciler.Any(o => o.OgrenciNo == ogrenciNo))
                    {
                        new Guna2MessageDialog
                        {
                            Caption = "Error!",
                            Text = "This Student Nubmer is Already in Use!",
                            Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                            Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                        }.Show();
                        return;
                    }


                    var yeniOgrenci = new Ogrenci
                    {
                        OgrenciNo = ogrenciNo,
                        Isim = isim,
                        Soyisim = soyisim,
                        password = sifre
                    };

                    db.Ogrenciler.Add(yeniOgrenci);
                    db.SaveChanges();
                    new Guna2MessageDialog
                    {
                        Caption = "Success",
                        Text = "Student Added Successfully!",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Information,
                        Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light
                    }.Show();

                }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void hideSwitch_CheckedChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = hideSwitch.Checked ? '\0' : '*';
        }
    }
}
