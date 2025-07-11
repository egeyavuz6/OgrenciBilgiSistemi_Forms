using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class ListCourse : Form
    {
        public ListCourse()
        {
            InitializeComponent();
            this.Load += ListCourse_Load;
        }

        private void ListCourse_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new OBSContext())
                {
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.BackgroundColor = Color.FromArgb(44, 47, 51);

                    var courses = context.Courses
                        .Select(c => new
                        {
                            CourseCode = c.Name,
                            Credit = c.Credit
                        })
                        .ToList();

                    dataGridView1.DataSource = courses;
                    dataGridView1.Columns[0].HeaderText = "Course Name";
                    dataGridView1.Columns[1].HeaderText = "Credits";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
