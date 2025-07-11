using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text.RegularExpressions;
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
                        CourseName = n.Course.Name,
                        n.Course.Credit
                    }))
                    .ToList();

                dataGridView1.DataSource = ogrenciNotlari;
                dataGridView1.Columns[0].HeaderText = "Student Number";
                dataGridView1.Columns[1].HeaderText = "Name";
                dataGridView1.Columns[2].HeaderText = "Last Name";
                dataGridView1.Columns[4].HeaderText = "Grades";
                dataGridView1.Columns[5].HeaderText = "Course Name";
                dataGridView1.Columns[6].HeaderText = "Credits";
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
            dataGridView1.Columns["Id"].Visible = false;
        }


        private void btnSil_Click_2(object sender, EventArgs e)
        {
            var msg = new Guna2MessageDialog
            {
                Caption = "Are You Sure",
                Text = "Do you want delete Grade?",
                Buttons = MessageDialogButtons.YesNo,
                Icon = MessageDialogIcon.Question,
                Style = MessageDialogStyle.Dark
            };

            var result = msg.Show();

            if (result == DialogResult.Yes)
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
            else
            {
                return;
            }

        }
        private void updateButton_Click(object sender, EventArgs e)
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
            var msg = new Guna2MessageDialog
            {
                Caption = "Information",
                Text = "Please enter a grade",
                Buttons = MessageDialogButtons.OK,
                Icon = MessageDialogIcon.Information,
                Style = MessageDialogStyle.Dark
            };

            var result = msg.Show();

            if (result == DialogResult.OK)
            {
                numericBox.Visible = true;
                okButton.Visible = true;
            }

            dataGridView1.Columns["Id"].Visible = true;
            int notId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            var not = db.Notlar.FirstOrDefault(n => n.Id == notId);

            double gradeValue = Convert.ToDouble(numericBox.Value);


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

            db.Notlar.Update(not);
            db.SaveChanges();

            new Guna2MessageDialog
            {
                Caption = "Success!",
                Text = "Grade Successfully Updated",
                Buttons = MessageDialogButtons.OK,
                Icon = MessageDialogIcon.Information,
            }.Show();

            //Tabloyu yenile
            NotSilForm_Load(null, null);


            new Guna2MessageDialog
            {
                Caption = "Error!",
                Text = $"An error occurred:",
                Buttons = MessageDialogButtons.OK,
                Icon = MessageDialogIcon.Error,
            }.Show();

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

        private void okButton_Click(object sender, EventArgs e)
        {
            numericBox.Visible = false;
            okButton.Visible = false;
            Regex regex = new Regex("^0-9\\d{0,4}$");
            if (!regex.IsMatch(numericBox.Text))
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = "Please enter integer only.",
                    Buttons = MessageDialogButtons.OK,
                    Icon = MessageDialogIcon.Error,
                }.Show();
            }
            if (Convert.ToDouble(numericBox.Value) > 100 || Convert.ToDouble(numericBox.Value) < 0)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = "Please enter a value between 0 and 100.",
                    Buttons = MessageDialogButtons.OK,
                    Icon = MessageDialogIcon.Error,
                }.Show();
            }
        }
    }
}
