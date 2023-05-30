namespace progetto_ristorante
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pcbNuovoUtente_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPasswordLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbPasswordLogin.Checked)
            {
                txbPassword.PasswordChar = '\0';
            }
            else
            {
                txbPassword.PasswordChar = '*'; 
            }
        }
    }
}
