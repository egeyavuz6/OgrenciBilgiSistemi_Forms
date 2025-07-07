using Guna.UI2.WinForms;
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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text.Trim();
            string sifre = textBox2.Text.Trim();
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
            using (var db = new OBSContext())
            {
                var yeniAdmin = new Admin(kullaniciAdi, sifre);
                db.Adminler.Add(yeniAdmin);
                //int sonuc = db.SaveChanges(); debugger
                //MessageBox.Show($"{sonuc} kayıt eklendi."); debugger
                new Guna2MessageDialog
                {
                    Text = $"Added New Admin",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light,
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
    }
}
