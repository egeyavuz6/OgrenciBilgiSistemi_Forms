using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    public partial class OgrenciSilForm : Form
    {
        List<Ogrenci> ogrenciListesi;
        private OBSContext db = new OBSContext();

        public OgrenciSilForm(List<Ogrenci> ogrenciler)
        {
            InitializeComponent();
            db = new OBSContext();
            ogrenciListesi = ogrenciler;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            var msg = new Guna2MessageDialog
            {
                Caption = "Are you sure?",
                Text = "Do you want to delete this Student?",
                Buttons = MessageDialogButtons.YesNo,
                Icon = MessageDialogIcon.Question,
                Style = MessageDialogStyle.Dark
            };

            var result = msg.Show();

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (studentTableView.SelectedRows.Count == 0)
                    {
                        new Guna2MessageDialog
                        {
                            Caption = "Error!",
                            Text = "You Need To Select A Student First",
                            Buttons = MessageDialogButtons.OK,
                            Icon = MessageDialogIcon.Error,
                        }.Show();
                        return;
                    }

                    string ogrenciNo = Convert.ToString(studentTableView.SelectedRows[0].Cells["OgrenciNo"].Value);
                    var ogrenci = db.Ogrenciler.FirstOrDefault(n => n.OgrenciNo == ogrenciNo);

                    db.Ogrenciler.Remove(ogrenci);
                    db.SaveChanges();

                    new Guna2MessageDialog
                    {
                        Caption = "Success!",
                        Text = "Student Successfully Deleted",
                        Buttons = MessageDialogButtons.OK,
                        Icon = MessageDialogIcon.Information,
                    }.Show();
                    //listeyi yenile
                    studentTableView.DataSource = db.Ogrenciler.Select(o => new
                    {
                        o.Isim,
                        o.Soyisim,
                        o.OgrenciNo,
                    }).ToList();

                }
                catch (Exception ex)
                {
                    new Guna2MessageDialog
                    {
                        Caption = "Error!",
                        Text = $"An error occurred: {ex.Message}",
                        Buttons = MessageDialogButtons.OK,
                        Icon = MessageDialogIcon.Error,
                    }.Show();
                }
            }
                else
                {
                return;
                }
                
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }

        private void OgrenciSilForm_Load(object sender, EventArgs e)
        {
            //açılınca listeyi doldur
            try
            {
                studentTableView.DataSource = db.Ogrenciler.Select(o => new
                {
                    o.Isim,
                    o.Soyisim,
                    o.OgrenciNo,
                }).ToList();
                studentTableView.Visible = true;
                studentTableView.Columns[0].HeaderText = "Name";
                studentTableView.Columns[1].HeaderText = "Last Name";
                studentTableView.Columns[2].HeaderText = "Student Number";
            }
            catch (SqlException sqlEx)
            {
                new Guna2MessageDialog
                {
                    Caption = "Database Error!",
                    Text = $"An error occurred while connecting to the database: {sqlEx.Message}",
                    Buttons = MessageDialogButtons.OK,
                    Icon = MessageDialogIcon.Error
                }.Show();
            }
            catch (Exception ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = $"An unexpected error occurred: {ex.Message}",
                    Buttons = MessageDialogButtons.OK,
                    Icon = MessageDialogIcon.Error
                }.Show();

            }
        }

        private void studentTableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


