using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class OrtalamaForm : Form
    {
        private OBSContext db;

        public OrtalamaForm(OBSContext dbContext)
        {
            InitializeComponent();
            db = dbContext;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void OrtalamaForm_Load(object sender, EventArgs e)
        {
            using (var db = new OBSContext())
            {
                var ogrenciler = db.Ogrenciler
                    .Select(o => new { o.OgrenciNo, o.Isim, o.Soyisim })
                    .ToList()
                    .Select(o => $"{o.OgrenciNo} - {o.Isim} {o.Soyisim}")
                    .ToList();
                comboBox.DataSource = ogrenciler;
            }
            comboBox.SelectedIndex = 0;
            

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                //student number and name combobox data source
                string selectedStudent = comboBox.SelectedItem.ToString();
                //selects the OgrenciNo from studentNumberNameCombo
                string[] comboOgrenci = selectedStudent.Split(new[] { "-" }, StringSplitOptions.None);
                string ogrenciNo = comboOgrenci[0];

                if (string.IsNullOrEmpty(ogrenciNo))
                {
                    new Guna2MessageDialog
                    {
                        Text = "Please fill the student number!",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                        Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                    }.Show();
                    return;
                }

                var ogrenci = db.Ogrenciler.Include(o => o.Notlar).FirstOrDefault(o => o.OgrenciNo == ogrenciNo);

                if (ogrenci == null)
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "Student Not Found!",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                        Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                    }.Show();
                    return;
                }

                if (ogrenci.Notlar == null || ogrenci.Notlar.Count == 0)
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = "This Student Doesn't Have Any Grade!",
                        Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                        Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                        Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

                    }.Show();
                    return;
                }

                double toplamAğırlıklıNot = 0.0;
                int toplamKredi = 0;
                foreach (var not in ogrenci.Notlar)
                {
                    var ders = db.Courses.FirstOrDefault(d => d.Id == not.CourseId);
                    if (ders != null)
                    {
                        toplamAğırlıklıNot += not.WeightedGrade * ders.Credit;
                        toplamKredi += ders.Credit;
                    }
                }

                double GPA = toplamAğırlıklıNot / toplamKredi;
                guna2HtmlLabel3.Text = $"{GPA}";
                guna2HtmlLabel4.Text = comboOgrenci[1];

                
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

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
