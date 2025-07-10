using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using OgrenciBilgiSistemi.Student;
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
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();

        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new OBSContext())
                {
                    string studentID = studentIDbox.Text.Trim();
                    string sifre = passwordBox.Text.Trim();


                    if (string.IsNullOrWhiteSpace(studentID) || string.IsNullOrWhiteSpace(sifre))
                    {
                        new Guna2MessageDialog
                        {
                            Caption = "Error!",
                            Text = "Student ID or password cannot be empty!",
                            Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                            Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
                        }.Show();
                        return;
                    }
                    Ogrenci ogrenci = db.Ogrenciler.FirstOrDefault(o => o.OgrenciNo == studentID && o.password == sifre);
                    if (ogrenci != null)
                    {
                        SessionManager.ogrenciId = ogrenci.Id;
                        SessionManager.StudentID = ogrenci.OgrenciNo;
                        SessionManager.StudentNameSurname = ogrenci.Isim +" " +ogrenci.Soyisim;
                        // Hide the current form and show the menu
                        this.Hide();
                        StudentMenu menu = new StudentMenu();
                        menu.Show();
                    }
                    else
                    {
                        new Guna2MessageDialog
                        {
                            Text = "Student ID or password is incorrect",
                            Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                            Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
                        }.Show();
                    }
                }
            }
            catch (SqlException ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "Database Error!",
                    Text = $"Something is wrong with the database: {ex.Message}",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
                }.Show();
            }
            catch (Exception ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "Error!",
                    Text = $"An error occurred: {ex.Message}",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,
                }.Show();
            }
        }




        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void studentIDbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hideSwitch_CheckedChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = hideSwitch.Checked ? '\0' : '*';
        }
    }
}
