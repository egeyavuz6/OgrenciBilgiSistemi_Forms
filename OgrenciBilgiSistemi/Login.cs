using Guna.UI2.WinForms;

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
                            Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light

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
            catch (Exception ex)
            {
                new Guna2MessageDialog
                {
                    Caption = "An Error Occured",
                    Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK,
                    Style = BackColor == Color.FromArgb(44, 47, 51) ? Guna.UI2.WinForms.MessageDialogStyle.Dark : Guna.UI2.WinForms.MessageDialogStyle.Light,
                    Icon = Guna.UI2.WinForms.MessageDialogIcon.Error
                }.Show();
            }
        }
    }
}

