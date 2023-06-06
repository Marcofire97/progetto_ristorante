using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace progetto_ristorante
{
    internal class Utilita
    {
		public static int id_utente;
		public static int N_acquisti = 0;
		public static string bonus_5, bonus_10, bonus_20;
		public static List<Ordinazioni> ordinazioni = new List<Ordinazioni>();
		public static List<ElementoCarrello> elementi_carrello = new List<ElementoCarrello>();
		[DllImport("wininet.dll")]

		private static extern bool InternetGetConnectedState(out int descrizione, int valoreriservato);

		public static bool controllo_email(string email, string? username, int caso)
		{
			//caso 0 = register - caso 1 = login
			Utenti_DB db = new Utenti_DB();

			if(caso == 0)
			{
				foreach (var utente in db.GetUtenti())
				{
					if (utente.Username.Trim() == username.Trim())
					{
						MessageBox.Show("L'username non è disponibile", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}

					if (utente.Email.Trim() == email.Trim())
					{
						MessageBox.Show("L'email è gia stata usata", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				}
			}

			email = email.Trim();

			if (string.IsNullOrEmpty(email))
			{
				MessageBox.Show("Inserire un indirizzo email", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if(caso == 0)
			{
				if (string.IsNullOrEmpty(username))
				{
					MessageBox.Show("Inserire uno username", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}

			try
			{
				MailAddress mailAddress = new(email);
			}
			catch (FormatException)
			{
				MessageBox.Show("Inserire un indirizzo email valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (email[email.Length - 4] == '.' || email[email.Length - 3] == '.')
			{
			}
			else
			{
				MessageBox.Show("Inserire un dominio delle email valido", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}
		public static bool controllo_password(string password)
		{

			if (string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Inserire una password", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (!Regex.IsMatch(password, "^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+])[0-9a-zA-Z!@#$%^&*()_+]{8,}$"))
			{
				MessageBox.Show("La password deve essere composta da almeno 8 caratteri, una lettera maiuscola, una minuscola, un carattere speciale e un numero", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		public static bool controllo_rete()
		{
			int desc;
			if (!InternetGetConnectedState(out desc, 0))
			{
				MessageBox.Show("Per procedere, connettiti ad internet.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		public static bool controllo_carrello(string prodotto)
		{
			foreach (var ordine in Utilita.ordinazioni)
			{
				if (ordine.Prodotto == prodotto)
				{
                    MessageBox.Show("Il prodotto è già nel carrello!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
				}
			}
			return false;
		}

		public static byte[] HashPassword(string passwordClear)
		{
			using (SHA256 hash = SHA256.Create())
			{
				byte[] passwordBytes = Encoding.UTF8.GetBytes(passwordClear);
				byte[] hashBytes = hash.ComputeHash(passwordBytes);

				return hashBytes;
			}
		}
	}
}
