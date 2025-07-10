using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;

namespace OgrenciBilgiSistemi
{
    public partial class Login : Form
    {
        private string connectionString = "@\"Server=DESKTOP-IBCCD9T\\SQLEXPRESS;Database=OgrenciBilgiSistemiDb;Trusted_Connection=True;TrustServerCertificate=True;\"";

        public Login()
        {
            InitializeComponent();
        }


        private void loginButton_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void hideSwitch_CheckedChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = hideSwitch.Checked ? '\0' : '*';
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            var msg = new Guna2MessageDialog
            {
                Caption = "Are You Sure",
                Text = "Do you want to Exit?",
                Buttons = MessageDialogButtons.YesNo,
                Icon = MessageDialogIcon.Question,
                Style = MessageDialogStyle.Dark
            };

            var result = msg.Show();

            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new OBSContext())
                {
                    string kullaniciAdi = usernameBox.Text.Trim();
                    string sifre = passwordBox.Text.Trim();

                    if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
                    {
                        new Guna2MessageDialog
                        {
                            Caption = "Error!",
                            Text = "Username or password cannot be empty!",
                            Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                            Icon = Guna.UI2.WinForms.MessageDialogIcon.Error,

                        }.Show();
                        return;
                    }

                    var admin = db.Adminler
                        .FirstOrDefault(a => a.KullaniciAdi == kullaniciAdi && a.Sifre == sifre);

                    if (admin != null)
                    {

                        this.Hide();
                        Menu menu = new Menu();
                        menu.Show();

                    }
                    else
                    {
                        new Guna2MessageDialog
                        {
                            Text = "Username or password is incorrect",
                            Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                            Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light,
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentLogin studentLogin = new StudentLogin();
            studentLogin.Show();
        }
    }
}

