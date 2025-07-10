using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace OgrenciBilgiSistemi
{
    public partial class AddAdmin : Form
    {
        private readonly OBSContext db;
        public AddAdmin()
        {
            InitializeComponent();
            db = new OBSContext();
        }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Regex nameRegex = new Regex("^[a-zA-Z0-9çÇğĞıİöÖşŞüÜ_\\s]{2,20}$");
            Regex intRegex = new Regex("^[0-9]{1,20}$");
            string kullaniciAdi = textBox1.Text.Trim();
            string sifre = textBox2.Text.Trim();

            if (kullaniciAdi.Length > 20)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error",
                    Text = $"Username must be shorter than 20 characters.",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
                }.Show();
                return;
            }
            if (sifre.Length > 20)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error",
                    Text = $"Password must be shorter than 20 characters.",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
                }.Show();
                return;
            }


                if (!nameRegex.IsMatch(kullaniciAdi))
            {
                new Guna2MessageDialog
                {
                    Caption = "Error",
                    Text = $"Username can only contain letters (a-z, A-Z), numbers (0-9), and _ only.",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
                }.Show();
                return;
            }
            if (!intRegex.IsMatch(sifre))
            {
                new Guna2MessageDialog
                {
                    Caption = "Error",
                    Text = $"Password can only contain numbers and must be between 1 and 20 characters long.",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
                }.Show();
                return;
            }
            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                new Guna2MessageDialog
                {
                    Caption = "Error",
                    Text = $"Please fill the username and password.",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error

                }.Show();
                return;
            }
            try
            {
                using (var db = new OBSContext())
                {
                    var yeniAdmin = new Admin(kullaniciAdi, sifre);
                    db.Adminler.Add(yeniAdmin);
                    db.SaveChanges();

                    //int sonuc = db.SaveChanges(); debugger
                    //MessageBox.Show($"{sonuc} kayıt eklendi."); debugger
                    new Guna2MessageDialog
                    {
                        Text = $"Added New Admin",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Information

                    }.Show();
                }
            }
            catch (SqlException ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error",
                    Text = $"Something wrong happened with Database{ex.Message}",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
                }.Show();

            }
            catch (Exception ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error",
                    Text = $"An error occurred while adding the admin: {ex.Message}",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
                }.Show();
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void hideSwitch_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = hideSwitch.Checked ? '\0' : '*' ;
        }
    }
}
