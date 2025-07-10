using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class RemoveCourse : Form
    {
        private OBSContext db;

        public RemoveCourse(List<Course> courses, OBSContext dbContext)
        {

            InitializeComponent();
            db = dbContext;

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                // Tüm dersleri listele
                var courses = db.Courses.ToList();

                if (courses.Count == 0)
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Info",
                        Text = "No courses found.",
                        Buttons = MessageDialogButtons.OK,
                        Icon = MessageDialogIcon.Information,
                    }.Show();
                    return;
                }

                dataGridView1.DataSource = courses.Select(c => new
                {
                    c.Id,
                    c.Credit
                }).ToList();

                dataGridView1.Visible = true;
                
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

        private void RemoveCourse_Load(object sender, EventArgs e)
        {

            btnListele.Visible = false;
            dataGridView1.Visible = true;
            var courses = db.Courses.ToList();

            if (courses.Count == 0)
            {
                new Guna2MessageDialog
                {
                    Caption = "Info",
                    Text = "No courses found.",
                    Buttons = MessageDialogButtons.OK,
                    Icon = MessageDialogIcon.Information,
                }.Show();
                return;
            }

            dataGridView1.DataSource = courses.Select(c => new
            {
                c.Id,
                c.Credit
            }).ToList();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            var msg = new Guna2MessageDialog
            {
                Caption = "Are you sure?",
                Text = "Do you want to delete this course?",
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
                            Text = "Please select a course to delete.",
                            Buttons = MessageDialogButtons.OK,
                            Icon = MessageDialogIcon.Error,
                        }.Show();
                        return;
                    }

                    string courseId = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();

                    //Silmeden önce bağlı not var mı kontrolü
                    //bool kullaniliyor = db.Notlar.Any(n => n.CourseId == courseId);
                    //if (kullaniliyor)
                    //{
                    //    new Guna2MessageDialog
                    //    {
                    //        Caption = "Cannot Delete",
                    //        Text = "This course has associated grades. Please delete them first.",
                    //        Buttons = MessageDialogButtons.OK,
                    //        Icon = MessageDialogIcon.Warning,
                    //    }.Show();
                    //    return;
                    //}

                    var course = db.Courses.FirstOrDefault(c => c.Id == courseId);
                    if (course == null)
                    {
                        new Guna2MessageDialog
                        {
                            Caption = "Error!",
                            Text = "Course not found.",
                            Buttons = MessageDialogButtons.OK,
                            Icon = MessageDialogIcon.Error,
                        }.Show();
                        return;
                    }

                    db.Courses.Remove(course);
                    db.Notlar.RemoveRange(db.Notlar.Where(n => n.CourseId == courseId)); // İlgili notları da sil
                    db.SaveChanges();

                    new Guna2MessageDialog
                    {
                        Caption = "Success!",
                        Text = "Course deleted successfully.",
                        Buttons = MessageDialogButtons.OK,
                        Icon = MessageDialogIcon.Information,
                    }.Show();

                    // Listeyi yenile
                    btnListele_Click(null, null);

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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

    }
}
