﻿namespace progetto_ristorante
{
	public partial class Login : Form
	{
		Utenti_DB db;
		public Login()
		{
			InitializeComponent();
			db = new Utenti_DB();
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

		private void btnAccedi_Click(object sender, EventArgs e)
		{
			if (Utilita.controllo_email(txbEmail.Text, null, 1) && Utilita.controllo_password(txbPassword.Text) && Utilita.controllo_rete())
			{
				Utenti utente = db.GetUtenti(txbEmail.Text);

				if (utente != null)
				{
					byte[] passwordhashata = Utilita.HashPassword(txbPassword.Text);
					string passwordhashatastring = BitConverter.ToString(passwordhashata).Replace("-", string.Empty);

					if(passwordhashatastring == utente.Password && utente.Email == txbEmail.Text)
					{
						MessageBox.Show("Bentornato!");
						//rimanda alla pagina principale
					}
					else
					{
						MessageBox.Show("Dati errati");
					}
				}
				else
				{
					MessageBox.Show("Utente non trovato", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
