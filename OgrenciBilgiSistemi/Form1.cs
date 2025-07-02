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

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(usernameBox.Text == "admin" && passwordBox.Text == "1234")
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre yanlýþ!");
            }
        }
    }
}
