using Guna.UI2.WinForms;
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
    public partial class StudentMenu : Form
    {
        List<Ogrenci> ogrenciListesi = new List<Ogrenci>();
        List<Course> courseList = new List<Course>();
        OBSContext dbContext = new OBSContext();
        public StudentMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void seeYourGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studentNum = SessionManager.StudentID;
            var student = dbContext.Ogrenciler.FirstOrDefault(o => o.OgrenciNo == studentNum);
            var notlar = dbContext.Notlar
                .Where(n => n.OgrenciId == student.Id)
                .ToList();

            if (notlar == null || notlar.Count == 0)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = "You Don't Have Any Grade!",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                }.Show();
                return;
            }
            else
            {
                this.Hide();
                ListNotes_Student listNotes = new ListNotes_Student(ogrenciListesi, dbContext);
                listNotes.Show();
            }
                
        }
        private void seeYourGPAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studentNum = SessionManager.StudentID;
            var student = dbContext.Ogrenciler.FirstOrDefault(o => o.OgrenciNo == studentNum);
            var notlar = dbContext.Notlar
                .Where(n => n.OgrenciId == student.Id)
                .ToList();

            if (notlar == null || notlar.Count == 0)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = "You Don't Have Any Grade!",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                }.Show();
                return;
            }
            else
            {
                this.Hide();
                SeeGPA seeGPA = new SeeGPA();
                seeGPA.Show();
            }
            
        }
        private void lecturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studentNum = SessionManager.StudentID;
            var student = dbContext.Ogrenciler.FirstOrDefault(o => o.OgrenciNo == studentNum);
            var notlar = dbContext.Notlar
                .Where(n => n.OgrenciId == student.Id)
                .ToList();

            if (notlar == null || notlar.Count == 0)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = "You Are Not Taking Any Course!",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                }.Show();
                return;
            }
            else
            {
                this.Hide();
                SeeGPA seeGPA = new SeeGPA();
                seeGPA.Show();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msg = new Guna2MessageDialog
            {
                Caption = "Are You Sure",
                Text = "Do you want to Exit?",
                Buttons = MessageDialogButtons.YesNo,
                Icon = MessageDialogIcon.Question,
                Style = MessageDialogStyle.Dark
            };

            var result = msg.Show();

            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }

        private void StudentMenu_Load(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Text = "Welcome "+SessionManager.StudentNameSurname;
        }
    }
}
