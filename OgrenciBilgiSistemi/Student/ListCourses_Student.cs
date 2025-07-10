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
    public partial class ListCourses_Student : Form
    {
        public ListCourses_Student()
        {
            InitializeComponent();
            this.Load += ListCourses_Student_Load;
        }

        private void ListCourses_Student_Load(object sender, EventArgs e)
        {
            try
            {

                using (var context = new OBSContext())
                {
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.BackgroundColor = Color.FromArgb(44, 47, 51);

                    //returns the list of courses that match with SessionManager.StudentID
                    var courses = context.Notlar.Where(o => o.OgrenciId == SessionManager.ogrenciId)
                        .Select(o => new
                        {
                            o.CourseId,
                            o.Course.Credit
                        })
                        .ToList();

                    dataGridView1.DataSource = courses;
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentMenu studentMenu = new StudentMenu();
            studentMenu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
