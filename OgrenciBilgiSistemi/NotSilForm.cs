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

        private void btnListele_Click_1(object sender, EventArgs e)
        {
            try
            {
                string ogrenciNo = textBox1.Text.Trim();

                if (string.IsNullOrEmpty(ogrenciNo))
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Please fill the Student Number!",
                        Buttons = MessageDialogButtons.OK,
                        Icon = MessageDialogIcon.Error,
                    }.Show();
                    return;
                }

                var ogrenci = db.Ogrenciler
                    .Include(o => o.Notlar)
                    .ThenInclude(n => n.Course)
                    .FirstOrDefault(o => o.OgrenciNo == ogrenciNo);

                if (ogrenci == null)
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Student Not Found!",
                        Buttons = MessageDialogButtons.OK,
                        Icon = MessageDialogIcon.Error,
                    }.Show();
                    return;
                }

                if (ogrenci.Notlar == null || !ogrenci.Notlar.Any())
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "This Student Doesn't Have Any Grade!",
                        Buttons = MessageDialogButtons.OK,
                        Icon = MessageDialogIcon.Error,
                    }.Show();
                    return;
                }

                dataGridView1.DataSource = ogrenci.Notlar.Select(n => new
                {
                    n.Id,
                    n.Grades,
                    CourseName = n.Course.Id,
                    n.Course.Credit
                }).ToList();

                dataGridView1.Visible = true;
                btnListele.Text = "Refresh List";
            }
            catch (Exception ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = $"An error occurred: {ex.Message}",
                    Buttons = MessageDialogButtons.OK,
                    Icon = MessageDialogIcon.Error
                }.Show();
            }
        }

        private void btnSil_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "You Need To Select A Grade First",
                        Buttons = MessageDialogButtons.OK,
                        Icon = MessageDialogIcon.Error,
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
                        Buttons = MessageDialogButtons.OK,
                        Icon = MessageDialogIcon.Error,
                    }.Show();
                    return;
                }

                db.Notlar.Remove(not);
                db.SaveChanges();

                new Guna2MessageDialog
                {
                    Caption = "Success!",
                    Text = "Grade Successfully Deleted",
                    Buttons = MessageDialogButtons.OK,
                    Icon = MessageDialogIcon.Information,
                }.Show();

                // Otomatik listeyi yenile
                btnListele_Click_1(null, null);
            }
            catch (Exception ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = $"An error occurred: {ex.Message}",
                    Buttons = MessageDialogButtons.OK,
                    Icon = MessageDialogIcon.Error,
                }.Show();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // opsiyonel
        }
    }
}
