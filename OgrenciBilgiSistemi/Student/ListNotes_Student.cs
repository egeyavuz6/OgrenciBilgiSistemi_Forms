using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                var studentNum = SessionManager.StudentID;
                var student = db.Ogrenciler.FirstOrDefault(o => o.OgrenciNo == studentNum);
                var notlar = db.Notlar
                    .Where(n => n.OgrenciId == student.Id)
                    .ToList();

                if (notlar == null || notlar.Count == 0)
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "This Student Doesn't Have Any Grade!",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                        Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                    }.Show();
                    StudentMenu menu = new StudentMenu();
                    menu.Show();
                }
                dataGridView1.Visible = true;
                dataGridView1.BackgroundColor = Color.FromArgb(44, 47, 51);
                dataGridView1.DataSource = notlar.Select(n => new
                {
                    n.Grades,
                    n.CourseId,
                    OgrenciNo = student.OgrenciNo,
                    OgrenciIsim = student.Isim,
                    OgrenciSoyisim = student.Soyisim
                }).ToList();
            }
            catch (Exception ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = $"An error occurred: {ex.Message}",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light
                }.Show();
            }
        }
    }
}
