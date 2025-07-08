using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class Menu : Form
    {
        List<Ogrenci> ogrenciListesi = new List<Ogrenci>();
        List<Course> courseList = new List<Course>();
        OBSContext dbContext = new OBSContext();

        public Menu()
        {
            InitializeComponent();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ogrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            OgrenciEkleForm ekleForm = new OgrenciEkleForm(ogrenciListesi, dbContext);
            ekleForm.Show();


        }

        private void ogrenciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            OgrenciSilForm silForm = new OgrenciSilForm(ogrenciListesi);
            silForm.Show();

        }

        private void ogrencileriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            OgrencileriListele listeleForm = new OgrencileriListele();
            listeleForm.Show();

        }

        private void notEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotEkleForm notForm = new NotEkleForm(ogrenciListesi);
            notForm.Show();

        }

        private void notSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrtalamaForm ortalamaForm = new OrtalamaForm(dbContext);
            ortalamaForm.Show();
        }


        private void notlarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotListeleForm listeleForm = new NotListeleForm(ogrenciListesi, dbContext);
            listeleForm.Show();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void adminEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAdmin addAdmin = new AddAdmin();
            addAdmin.Show();
        }

        private void notSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotSilForm notSilForm = new NotSilForm(ogrenciListesi, dbContext);
            notSilForm.Show();

        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCourses addCourses = new AddCourses(courseList, dbContext);
            addCourses.Show();

        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveCourse removeCourse = new RemoveCourse(courseList, dbContext);
            removeCourse.Show();

        }

        private void listCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //ListCourse listCourse = new ListCourse(courseList, dbContext);
            //listCourse.Show();

        }
    }
}