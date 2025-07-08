using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class OrtalamaForm : Form
    {
        private OBSContext db;

        public OrtalamaForm(OBSContext dbContext)
        {
            InitializeComponent();
            db = dbContext;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try { 
            string ogrenciNo = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(ogrenciNo))
            {
                new Guna2MessageDialog
                {
                    Text = "Please fill the student number!",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                }.Show();
                return;
            }

            var ogrenci = db.Ogrenciler.Include(o => o.Notlar).FirstOrDefault(o => o.OgrenciNo == ogrenciNo);

            if (ogrenci == null)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = "Student Not Found!",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                }.Show();
                return;
            }

            if (ogrenci.Notlar == null || ogrenci.Notlar.Count == 0)
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

            double ortalama = ogrenci.Notlar.Average(n => n.Grades);
            new Guna2MessageDialog
            {
                Text = $"Average: {ortalama:F2}",
                Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

            }.Show();
            }
            catch(Exception ex)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
