using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class NotListeleForm : Form
    {
        private List<Ogrenci> ogrenciListesi;
        private OBSContext db;

        public NotListeleForm(List<Ogrenci> ogrenciler, OBSContext dbContext)
        {
            InitializeComponent();
            ogrenciListesi = ogrenciler;
            db = dbContext;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                string selectedStudent = guna2ComboBox1.SelectedItem.ToString();
                string[] comboOgrenci = selectedStudent.Split(new[] { "-" }, StringSplitOptions.None);
                string ogrenciNo = comboOgrenci[0].Trim();

                if (string.IsNullOrEmpty(ogrenciNo))
                {
                    new Guna2MessageDialog
                    {
                        Text = "Please fill the student number!",
                        Buttons = MessageDialogButtons.OK,
                        Icon = MessageDialogIcon.Error,
                        
                    }.Show();
                    return;
                }

                using (var context = new OBSContext())
                {
                    var notlar = context.Notlar
                        .Include(n => n.Ogrenci)
                        .Include(n => n.Course)
                        .Where(n => n.Ogrenci.OgrenciNo == ogrenciNo)
                        .Select(n => new
                        {
                            n.Ogrenci.Isim,
                            n.Ogrenci.Soyisim,
                            CourseName = n.Course.Name,
                            n.Course.Credit,
                            n.Grades
                        })
                        .ToList();


                    if (notlar.Count == 0)
                    {
                        new Guna2MessageDialog
                        {
                            Caption = "Error!",
                            Text = "This Student Doesn't Have Any Grade!",
                            Buttons = MessageDialogButtons.OK,
                            Icon = MessageDialogIcon.Error,
                            
                        }.Show();
                        return;
                    }
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.BackgroundColor = Color.FromArgb(44, 47, 51);
                    dataGridView1.DataSource = notlar;
                    dataGridView1.Columns[0].HeaderText = "Name";
                    dataGridView1.Columns[1].HeaderText = "Surname";
                    dataGridView1.Columns[2].HeaderText = "Course Name";
                    dataGridView1.Columns[3].HeaderText = "Credit";
                    dataGridView1.Columns[4].HeaderText = "Grades";

                }
            }
            catch (Exception ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = $"An error occurred: {ex.Message}",
                    Buttons = MessageDialogButtons.OK,
                    Icon = MessageDialogIcon.Error
                }.Show();
            }
        }



        private void NotListeleForm_Load_1(object sender, EventArgs e)
        {
            try
            {
                using (var db = new OBSContext())
                {
                    var ogrenciler = db.Ogrenciler
                        .Select(o => new { o.OgrenciNo, o.Isim, o.Soyisim })
                        .ToList()
                        .Select(o => $"{o.OgrenciNo} - {o.Isim} {o.Soyisim}")
                        .ToList();
                    guna2ComboBox1.DataSource = ogrenciler;
                }
                guna2ComboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = $"Form yüklenirken hata oluştu: {ex.Message}",
                    Buttons = MessageDialogButtons.OK,
                    Icon = MessageDialogIcon.Error
                }.Show();
            }
            
        }
    }
}
