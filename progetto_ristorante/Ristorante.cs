using progetto_ristorante;

namespace progetto_ristorante
{
	public partial class Ristorante : Form
	{
		public Ristorante()
		{
			InitializeComponent();
		}

		private void ConfigGroupBox_Enter(object sender, EventArgs e)
		{

		}

		private void TwitterButton_Click(object sender, EventArgs e)
		{
			System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
			{
				FileName = "explorer.exe",
				Arguments = "https://twitter.com"
			};

			System.Diagnostics.Process.Start(psi);
		}

		private void InstagramButton_Click(object sender, EventArgs e)
		{
			System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
			{
				FileName = "explorer.exe",
				Arguments = "https://instagram.com"
			};

			System.Diagnostics.Process.Start(psi);
		}

		private void FacebookButton_Click(object sender, EventArgs e)
		{
			System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
			{
				FileName = "explorer.exe",
				Arguments = "https://facebook.com"
			};

			System.Diagnostics.Process.Start(psi);
		}

		private void MinimizeButton_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void btnOrdinaOraPromo_Click(object sender, EventArgs e)
		{

		}

		private void ShoppingCart_Click(object sender, EventArgs e)
		{
			new Carrello().Show();
			this.Hide();
		}

		private void ordine1_Load(object sender, EventArgs e)
		{

		}

		private void TakeButton_Click(object sender, EventArgs e)
		{
			new TakeAway().Show();
			this.Hide();
		}

		private void HomeButton_Click(object sender, EventArgs e)
		{
			if (this.GetType() != typeof(Ristorante))
			{
				Ristorante ristoranteForm = new Ristorante();
				ristoranteForm.Show();
				this.Hide();
			}
		}

		private void btnVaiOfferte_Click(object sender, EventArgs e)
		{
			new Offerte().Show();
			this.Hide();
		}

		private void btnVaiAlDelivery_Click(object sender, EventArgs e)
		{
			new Delivery().Show();
			this.Hide();
		}

		private void btnVaiAlleImpostazioni_Click(object sender, EventArgs e)
		{
			new Cliente().Show();
			this.Hide();
		}

		private void btnVaiEatIn_Click(object sender, EventArgs e)
		{
			new EatIn().Show();
			this.Hide();
		}
	}
}
