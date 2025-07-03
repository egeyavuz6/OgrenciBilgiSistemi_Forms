namespace OgrenciBilgiSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Admin admin = new Admin("admin", "1234");

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = usernameBox.Text;
            string sifre = passwordBox.Text;
            Admin admin = new Admin(kullaniciAdi, sifre);
            if (admin.GirisYap(kullaniciAdi, sifre))
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre yanlýþ.");
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Var olan bir admin ile ekleme yapýlabilir. \n");


        }
    }
}
