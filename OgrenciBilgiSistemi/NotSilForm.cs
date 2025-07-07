using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class NotSilForm : Form
    {
        private OBSContext db;

        public NotSilForm(List<Ogrenci> ogrenciler, OBSContext dbContext)
        {
            InitializeComponent();
            db = dbContext;
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {


        }


        private void btnListele_Click_1(object sender, EventArgs e)
        {
            string ogrenciNo = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(ogrenciNo))
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = "Please fill the Student Number!",
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

            dataGridView1.DataSource = ogrenci.Notlar.Select(n => new
            {
                n.Id,
                n.Deger
            }).ToList();
            dataGridView1.Visible = true;
            btnListele.Text = "Refresh List";
        }

        private void btnSil_Click_2(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = "You Need To Select A Grade First",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                }.Show();
                return;
            }

            int notId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            var not = db.Notlar.FirstOrDefault(n => n.Id == notId);
            if (not == null)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = "No Grades Found!",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                }.Show();
                return;
            }

            db.Notlar.Remove(not);
            db.SaveChanges();
            new Guna2MessageDialog
            {
                Caption = "Success!",
                Text = "Grade Successfully Deleted",
                Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

            }.Show();

            btnSil_Click_1(null, null);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
