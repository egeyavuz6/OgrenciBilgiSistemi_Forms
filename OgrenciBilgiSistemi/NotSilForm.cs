using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
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

        private void NotSilForm_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Visible = true;

                var ogrenciNotlari = db.Ogrenciler
                    .Include(o => o.Notlar)
                    .ThenInclude(n => n.Course)
                    .SelectMany(o => o.Notlar.Select(n => new
                    {
                        o.OgrenciNo,
                        o.Isim,
                        o.Soyisim,
                        n.Id,
                        n.Grades,
                        CourseName = n.Course.Id,
                        n.Course.Credit
                    }))
                    .ToList();

                dataGridView1.DataSource = ogrenciNotlari;
            }
            catch (SqlException ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = "Error with database." + ex.Message,
                    Buttons = MessageDialogButtons.OK,
                    Icon = MessageDialogIcon.Error,
                }.Show();
            }
            catch (Exception ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = ex.Message,
                    Buttons = MessageDialogButtons.OK,
                    Icon = MessageDialogIcon.Error,
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

                // Tabloyu yenile
                NotSilForm_Load(null, null);
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
            
        }
    }
}
