using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ogrenciNo = txtNo.Text.Trim();
            string isim = txtAd.Text.Trim();
            string soyisim = txtSoyad.Text.Trim();

            if (string.IsNullOrEmpty(ogrenciNo) || string.IsNullOrEmpty(isim) || string.IsNullOrEmpty(soyisim))
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = "Please Fill All of Them",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

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
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

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
                        Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                    }.Show();
                    return;
                }


                var yeniOgrenci = new Ogrenci
                {
                    OgrenciNo = ogrenciNo,
                    Isim = isim,
                    Soyisim = soyisim
                };

                db.Ogrenciler.Add(yeniOgrenci);
                db.SaveChanges();
                new Guna2MessageDialog
                {
                    Caption = "Success",
                    Text = "Student Added Successfully!",
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
