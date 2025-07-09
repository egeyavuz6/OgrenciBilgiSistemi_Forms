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
            this.Hide();
            ListNotes_Student listNotes = new ListNotes_Student(ogrenciListesi, dbContext);
            listNotes.Show();
        }
        private void seeYourGPAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeeGPA seeGPA = new SeeGPA();
            seeGPA.Show();
        }
        private void lecturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListCourses_Student listCourses = new ListCourses_Student();
            listCourses.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


    }
}
