using System.Diagnostics;

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
			string clientId = "Il_tuo_client_id";
			string redirectUri = "https://localhost"; // L'URL di reindirizzamento registrato nel tuo progetto Google API Console

			string authorizationEndpoint = "https://accounts.google.com/o/oauth2/v2/auth";
			string tokenEndpoint = "https://oauth2.googleapis.com/token";
			string userInfoEndpoint = "https://www.googleapis.com/oauth2/v3/userinfo";

			string scope = "openid email profile"; // Scopes richiesti per l'autorizzazione

			// Genera lo stato casuale per l'autenticazione
			string state = Guid.NewGuid().ToString();

			// Crea l'URL di autorizzazione per reindirizzare l'utente a Google
			string authorizationUrl = $"{authorizationEndpoint}?response_type=code&client_id={clientId}&redirect_uri={redirectUri}&scope={scope}&state={state}";

			// Apre il browser predefinito dell'utente con l'URL di autorizzazione
			Process.Start(authorizationUrl);
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}