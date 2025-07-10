using Guna.UI2.WinForms;
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
            try {
                Regex regex = new Regex("^[a-zA-Z0-9çÇğĞıİöÖşŞüÜ_\\s]{2,50}$");
                string courseId = nameBox.Text.Trim();
                double credit = double.Parse(creditBox.Text.Trim());
                if (string.IsNullOrEmpty(courseId) || string.IsNullOrEmpty(courseId))
                {
                    new Guna.UI2.WinForms.Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Please Fill All of Them",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    }.Show();
                    return;
                }
                //credit sadece rakamlardan oluşmalı
                if (!double.TryParse(creditBox.Text, out _))
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Credit must be a number!",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    }.Show();
                    return;
                }
                if (!regex.IsMatch(courseId)){
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Course Name Can Contain Numbers and Letters Only!",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    }.Show();
                    return;
                }


                using (var db = new OBSContext())
                {
                    if (db.Courses.Any(o => o.Id == courseId))
                    {
                        new Guna2MessageDialog
                        {
                            Caption = "Error!",
                            Text = "This Course Name is Already in Use!",
                            Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                            Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                        }.Show();
                        return;
                    }


                    var yeniCourse = new Course
                    {
                        Credit = credit,
                        Id = courseId
                    };

                    db.Courses.Add(yeniCourse);
                    db.SaveChanges();
                    new Guna2MessageDialog
                    {
                        Caption = "Success",
                        Text = "Course Added Successfully!",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Information,
                        Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light,
                    }.Show();

                }

            }
            catch (Exception ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = $"An error occurred: {ex.Message}",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
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
