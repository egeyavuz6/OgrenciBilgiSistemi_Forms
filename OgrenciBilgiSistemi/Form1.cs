namespace OgrenciBilgiSistemi
{
    public partial class Form1 : Form
    {
        private string connectionString = "@\"Server=DESKTOP-IBCCD9T\\SQLEXPRESS;Database=OgrenciBilgiSistemiDb;Trusted_Connection=True;TrustServerCertificate=True;\"";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new OBSContext())
                {
                    string kullaniciAdi = usernameBox.Text.Trim();
                    string sifre = passwordBox.Text.Trim();

                    if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
                    {
                        MessageBox.Show("Kullan�c� ad� ve �ifre bo� olamaz.");
                        return;
                    }

                    var admin = db.Adminler
                        .FirstOrDefault(a => a.KullaniciAdi == kullaniciAdi && a.Sifre == sifre);

                    if (admin != null)
                    {
                        MessageBox.Show("Giri� ba�ar�l�!");
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide(); 
                    }
                    else
                    {
                        MessageBox.Show("Kullan�c� ad� veya �ifre hatal�.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giri� s�ras�nda bir hata olu�tu.\n\nHata: " + ex.Message,
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}

