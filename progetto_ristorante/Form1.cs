using System.Diagnostics;
using Google.Apis.Auth;
using Google.Apis.PeopleService.v1;
using Google.Apis.Services;



namespace progetto_ristorante
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void pictureBox5_Click(object sender, EventArgs e)
		{
			// Aggiungi login con Google
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Utenti_DB db = new Utenti_DB();
			Utenti utente1 = new Utenti(1, "m44comd@gmail.com", "lollone1234", "Ciao1234");


			foreach(var u in db.GetUtenti())
			{
				MessageBox.Show(u.ID + u.Email + u.Username + u.Password);
            }
		}
	}
}