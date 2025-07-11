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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OgrenciBilgiSistemi.Student
{
    public partial class SeeGPA : Form
    {
        private readonly OBSContext db;
        public SeeGPA()
        {

            InitializeComponent();
            db = new OBSContext();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentMenu studentMenu = new StudentMenu();
            studentMenu.Show();
        }

        private void SeeGPA_Load(object sender, EventArgs e)
        {
            gpaSonucBox.Text = "";
            creditSonucBox.Text = "";
            try
            {
                string ogrenciNo = SessionManager.StudentID;

                var ogrenci = db.Ogrenciler.Include(o => o.Notlar).FirstOrDefault(o => o.OgrenciNo == ogrenciNo);

                if (ogrenci.Notlar == null || ogrenci.Notlar.Count == 0)
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "You Don't Have Any Grade!",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,

                    }.Show();
                    return;
                }

                double toplamAğırlıklıNot = 0.0;
                double toplamKredi = 0;
                var dersler = db.Courses.ToDictionary(d => d.Id, d => d.Credit);

                foreach (var not in ogrenci.Notlar)
                {
                    if (dersler.TryGetValue(not.CourseId, out double kredi))
                    {
                        toplamAğırlıklıNot += not.WeightedGrade * kredi;
                        toplamKredi += kredi;
                    }
                }

                double GPA = toplamAğırlıklıNot / toplamKredi;

                gpaSonucBox.Text = $"{GPA:F2}";
                creditSonucBox.Text = $"Total Credits: {toplamKredi}";
            }
            catch (Exception ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = $"An error occurred: {ex.Message}",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
                }.Show();

            }
        }

        private void gpaSonucBox_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
