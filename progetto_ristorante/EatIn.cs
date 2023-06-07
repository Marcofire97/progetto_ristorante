using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_ristorante
{
	public partial class EatIn : Form
	{
		DateTime data = DateTime.Now;
		public EatIn()
		{
			InitializeComponent();
		}

		private void pcbTornaHomeEatIn_Click(object sender, EventArgs e)
		{
			new Ristorante().Show();
			this.Hide();
		}

		private void btnAcquistaBurger_Click(object sender, EventArgs e)
		{
			if (!Utilita.controllo_carrello("Burger"))
			{
				Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Burger", 1, Image.FromFile(@"Foto/burger.jpg"), 9));
				MessageBox.Show("Ordine aggiunto al carrello", "Ordine aggiunto", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
		}

		private void btnAcquistaPasta_Click(object sender, EventArgs e)
		{
			if (!Utilita.controllo_carrello("Lasagna"))
			{
				Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Lasagna", 1, Image.FromFile(@"Foto/lasagna.jpg"), 8));
				MessageBox.Show("Ordine aggiunto al carrello", "Ordine aggiunto", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
		}

		private void btnAcquistaTorta_Click(object sender, EventArgs e)
		{
			if (!Utilita.controllo_carrello("Torta"))
			{
				Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Torta", 1, Image.FromFile(@"Foto/torta.jpg"), 11));
				MessageBox.Show("Ordine aggiunto al carrello", "Ordine aggiunto", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
		}
	}
}
