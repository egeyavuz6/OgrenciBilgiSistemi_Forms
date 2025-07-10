using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class AddCourses : Form
    {
        List<Course> courseList;
        private OBSContext db;

        public AddCourses(List<Course> courses, OBSContext dbContext)
        {
            InitializeComponent();
            courseList = courses;
            db = dbContext;
        }

        public AddCourses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Regex regex = new Regex("^[a-zA-Z0-9çÇğĞıİöÖşŞüÜ_\\s]{2,50}$");
                string courseName = nameBox.Text.Trim();  // artık Id değil, Name!
                string creditText = creditBox.Text.Trim();

                if (string.IsNullOrEmpty(courseName) || string.IsNullOrEmpty(creditText))
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Please fill all of the fields.",
                        Buttons = MessageDialogButtons.OK,
                        Icon = MessageDialogIcon.Error
                    }.Show();
                    return;
                }

                if (!double.TryParse(creditText, out double credit))
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Credit must be a valid number.",
                        Buttons = MessageDialogButtons.OK,
                        Icon = MessageDialogIcon.Error
                    }.Show();
                    return;
                }

                if (!regex.IsMatch(courseName))
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Course name can contain only letters, numbers, and spaces.",
                        Buttons = MessageDialogButtons.OK,
                        Icon = MessageDialogIcon.Error
                    }.Show();
                    return;
                }

                using (var db = new OBSContext())
                {
                    if (db.Courses.Any(c => c.Name == courseName))
                    {
                        new Guna2MessageDialog
                        {
                            Caption = "Error!",
                            Text = "This course name is already in use!",
                            Buttons = MessageDialogButtons.OK,
                            Icon = MessageDialogIcon.Error
                        }.Show();
                        return;
                    }

                    var yeniCourse = new Course
                    {
                        Name = courseName,
                        Credit = credit
                        // Id EF tarafından otomatik atanacak
                    };

                    db.Courses.Add(yeniCourse);
                    db.SaveChanges();

                    new Guna2MessageDialog
                    {
                        Caption = "Success",
                        Text = "Course added successfully!",
                        Buttons = MessageDialogButtons.OK,
                        Icon = MessageDialogIcon.Information,
                        Style = BackColor == Color.FromArgb(44, 47, 51)
                            ? MessageDialogStyle.Dark
                            : MessageDialogStyle.Light
                    }.Show();
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
