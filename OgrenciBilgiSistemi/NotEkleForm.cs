using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class NotEkleForm : Form
    {
        List<Ogrenci> ogrenciListesi;

        public NotEkleForm(List<Ogrenci> ogrenciler)
        {
            InitializeComponent();
            ogrenciListesi = ogrenciler;
        }



        private void NotEkleForm_Load(object sender, EventArgs e)
        {
            //combobox's data source
            guna2ComboBox1.DataSource = null;
            using (var db = new OBSContext())
            {
                var courses = db.Courses.Select(c => c.Id).ToList();
                guna2ComboBox1.DataSource = courses;
            }
            //student number and name combobox data source
            studentNumberNameCombo.DataSource = null;
            using (var db = new OBSContext()) {
                var ogrenciler = db.Ogrenciler
                    .Select(o => new { o.OgrenciNo, o.Isim, o.Soyisim })
                    .ToList()
                    .Select(o => $"{o.OgrenciNo} - {o.Isim} {o.Soyisim}")
                    .ToList();
                studentNumberNameCombo.DataSource = ogrenciler;
            }

        }
        

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string grade = txtNot.Text.Trim();
                int courseId = Convert.ToInt32(guna2ComboBox1.SelectedItem);


                string selectedStudent = studentNumberNameCombo.SelectedItem.ToString();
                //selects the OgrenciNo from studentNumberNameCombo
                string[] comboOgrenci = selectedStudent.Split(new[] { "-" }, StringSplitOptions.None);
                string ogrenciNo = comboOgrenci[0];
                if (string.IsNullOrEmpty(selectedStudent))
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Please Select a Student",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    }.Show();
                    return;
                }

                if (guna2ComboBox1.SelectedItem == null)
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Please Select a Course",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    }.Show();
                    return;
                }

                if (string.IsNullOrEmpty(ogrenciNo) || string.IsNullOrEmpty(grade))
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Please Fill Grade",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,

                    }.Show();
                    return;
                }
                using (var db = new OBSContext())
                {
                    var ogrenci = db.Ogrenciler.Include(o => o.Notlar).FirstOrDefault(o => o.OgrenciNo == ogrenciNo);
                    var course = db.Courses.FirstOrDefault(d => d.Id == courseId);
                    if (course == null)
                    {
                        new Guna2MessageDialog
                        {
                            Caption = "Error!",
                            Text = "Course Doesn't Exist",
                            Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                            Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                        }.Show();
                        return;
                    }

                    if (ogrenci == null)
                    {
                        new Guna2MessageDialog
                        {
                            Caption = "Error!",
                            Text = "Student Doesn't Exist",
                            Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                            Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,

                        }.Show();
                        return;
                    }
                    if (!double.TryParse(grade, out double notDegeri))
                    {
                        new Guna2MessageDialog
                        {
                            Caption = "Error!",
                            Text = "Please Enter an Integer between 0 and 100",
                            Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                            Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                            

                        }.Show();
                        return;
                    }
                    if (ogrenci.Notlar.Any(n => n.CourseId == course.Id))
                    {
                        new Guna2MessageDialog
                        {
                            Caption = "Error!",
                            Text = "This Student Already Has a Grade for This Course",
                            Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                            Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                            
                        }.Show();
                        return;
                    }
                    if (notDegeri < 0 || notDegeri > 100)
                    {
                        new Guna2MessageDialog
                        {
                            Caption = "Error!",
                            Text = "Grade must be an Integer in a range between 0 and 100",
                            Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                            Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                            
                        }.Show();
                        return;
                    }

                    double weightedGrade = 0.0;
                    if (notDegeri < 50) { weightedGrade = 0.0; }//FF
                    else if (notDegeri < 60) { weightedGrade = 1.0; }//DD
                    else if (notDegeri < 65) { weightedGrade = 1.5; }//DC
                    else if (notDegeri < 70) { weightedGrade = 2.0; }//CC
                    else if (notDegeri < 75) { weightedGrade = 2.5; }//CB
                    else if (notDegeri < 80) { weightedGrade = 3.0; }//BB
                    else if (notDegeri < 85) { weightedGrade = 3.5; }//BA
                    else if (notDegeri <= 100) { weightedGrade = 4.0; }//AA

                    ogrenci.NotEkle(notDegeri, courseId, weightedGrade);
                    db.SaveChanges();
                    new Guna2MessageDialog
                    {
                        Caption = "Success!",
                        Text = "Grade Successfully Added",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Information,
                        Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light
                        

                    }.Show();
                    txtNot.Clear();
                }
                guna2ComboBox1.SelectedIndex = -1;
                
            }
            catch
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = "An unexpected error occurred. Please try again.",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                }.Show();

            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void studentNumberNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
