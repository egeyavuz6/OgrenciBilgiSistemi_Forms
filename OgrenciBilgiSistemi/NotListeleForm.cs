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
                            n.Course.Id,
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

                    guna2DataGridView1.AutoGenerateColumns = true;
                    guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    guna2DataGridView1.BackgroundColor = Color.FromArgb(44, 47, 51);
                    guna2DataGridView1.DataSource = notlar;
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


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
