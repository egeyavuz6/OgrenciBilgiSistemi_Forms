using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi.Student
{
    public partial class ListNotes_Student : Form
    {
        private DataGridView dataGridView1;
        private List<Ogrenci> ogrenciListesi;
        private OBSContext db;

        public ListNotes_Student(List<Ogrenci> students, OBSContext dbContext)
        {
            InitializeComponent();
            ogrenciListesi = students;
            db = dbContext;

            dataGridView1 = new DataGridView
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(dataGridView1);
            dataGridView1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentMenu menu = new StudentMenu();
            menu.Show();
        }

        private void ListNotes_Student_Load(object sender, EventArgs e)
        {
            try
            {
                string studentNum = SessionManager.StudentID;
                var student = db.Ogrenciler.FirstOrDefault(o => o.OgrenciNo == studentNum);

                if (student == null)
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Student not found.",
                        Buttons = MessageDialogButtons.OK,
                        Icon = MessageDialogIcon.Error
                    }.Show();
                    return;
                }

                var notlar = db.Notlar
                    .Include(n => n.Course)
                    .Where(n => n.OgrenciId == student.Id)
                    .ToList();

                if (notlar == null || notlar.Count == 0)
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "You don't have any grade.",
                        Buttons = MessageDialogButtons.OK,
                        Icon = MessageDialogIcon.Error,
                        Style = BackColor == Color.FromArgb(44, 47, 51) ? MessageDialogStyle.Dark : MessageDialogStyle.Light
                    }.Show();
                    return;
                }

                dataGridView1.Visible = true;
                dataGridView1.BackgroundColor = Color.FromArgb(44, 47, 51);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = notlar.Select(n => new
                {
                    n.Grades,
                    CourseName = n.Course != null ? n.Course.Name : "(Deleted Course)",
                    student.OgrenciNo,
                    student.Isim,
                    student.Soyisim
                }).ToList();
            }
            catch (Exception ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = $"An error occurred: {ex.Message}",
                    Buttons = MessageDialogButtons.OK,
                    Icon = MessageDialogIcon.Error,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? MessageDialogStyle.Dark : MessageDialogStyle.Light
                }.Show();
            }
        }
    }
}
