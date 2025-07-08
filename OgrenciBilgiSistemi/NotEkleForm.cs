using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class NotEkleForm : Form
    {
        List<Ogrenci> ogrenciListesi;

        public NotEkleForm(List<Ogrenci> ogrenciler)
        {
            InitializeComponent();
            ogrenciListesi = ogrenciler;
        }



        private void NotEkleForm_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            try { 
            string ogrenciNo = txtNo.Text.Trim();
            string grade = txtNot.Text.Trim();
            if (string.IsNullOrEmpty(ogrenciNo) || string.IsNullOrEmpty(grade))
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = "Please Fill The Blanks",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                }.Show();
                return;
            }
            using (var db = new OBSContext())
            {
                var ogrenci = db.Ogrenciler.Include(o => o.Notlar).FirstOrDefault(o => o.OgrenciNo == ogrenciNo);
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
                if (!double.TryParse(grade, out double notDegeri))
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Please Enter an Integer between 0 and 100",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                        Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                    }.Show();
                    return;
                }
                if (notDegeri < 0 || notDegeri > 100)
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Grade must be an Integer in a range between 0 and 100",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                        Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                    }.Show();
                    return;
                }
                ogrenci.NotEkle(notDegeri);
                db.SaveChanges();
                new Guna2MessageDialog
                {
                    Caption = "Success!",
                    Text = "Grade Successfully Added",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                }.Show();
                txtNot.Clear();
            }
            }
            catch
            {   
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = "An unexpected error occurred. Please try again.",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                }.Show();

            }
        }
    }
}
