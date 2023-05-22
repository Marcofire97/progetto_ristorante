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
			Utenti utente1 = new Utenti(1, "bdtde1234@gmail.com", "lollone1234", "Ciao1234");


			db.AddUtente(utente1);
		}
	}
}