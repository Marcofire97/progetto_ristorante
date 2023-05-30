using System;
using System.Text.RegularExpressions;

namespace progetto_ristorante
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            if (Utilita.controllo_email(txbEmailRegister.Text, txbUtenteRegister.Text) && Utilita.controllo_password(txbPasswordRegister.Text) && Utilita.controllo_rete())
            {
                
            }

        }

        private void pcbVaialLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void txbPasswordRegister_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPasswordRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbPasswordRegister.Checked)
            {
                txbPasswordRegister.PasswordChar = '\0';
            }
            else
            {
                txbPasswordRegister.PasswordChar = '*';
            }
        }

        private void txbUtenteRegister_TextChanged(object sender, EventArgs e)
        {
            string input = txbUtenteRegister.Text;
            string asciiPattern = @"^[\x00-\x7F]*$"; 

            if (!Regex.IsMatch(input, asciiPattern))
            {
                txbUtenteRegister.Text = string.Empty; 
                MessageBox.Show("Sono ammessi solo caratteri ASCII.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}