using SA.AUTApp.BLL.Concrete;

namespace SA.AUTApp.UI
{
    public partial class Giris : Form
    {
        KullaniciServise KullaniciServise = new KullaniciServise(new DAL.Concrete.KullaniciRepo(new DAL.Context.SA_AUTAppDbContext()));
        public Giris()
        {
            InitializeComponent();

        }
         public int failedAttempts = 0;
        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int giris = KullaniciServise.Login(textBox1.Text, textBox2.Text);
           
            if (giris == 0)
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                failedAttempts++;
                MessageBox.Show("Kullanýcý adý veya þifre hatasý");

                if (failedAttempts >= 3)
                {
                    Application.Exit();
                }
                else
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
        }
    }
}