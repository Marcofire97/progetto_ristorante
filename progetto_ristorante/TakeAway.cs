using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_ristorante
{
	public partial class TakeAway : Form
	{
		DateTime data = DateTime.Now;
		public TakeAway()
		{
			InitializeComponent();
		}

		private void pcbTornaHomeTakeAway_Click(object sender, EventArgs e)
		{
			new Ristorante().Show();
			this.Hide();
		}

		private void btnPezzodiTorta_Click(object sender, EventArgs e)
		{
			if (!Utilita.controllo_carrello("Pezzo di torta"))
			{
				Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Pezzo di torta", 1, Image.FromFile(@"Foto/pezzo di torta.jpg"), 3));
				MessageBox.Show("Ordine aggiunto al carrello", "Ordine aggiunto", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
		}

		private void btnPezzodiPizza_Click(object sender, EventArgs e)
		{
			if (!Utilita.controllo_carrello("Pezzo di pizza"))
			{
				Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Pezzo di pizza", 1, Image.FromFile(@"Foto/pezzo di pizza.jpg"), 2));
				MessageBox.Show("Ordine aggiunto al carrello", "Ordine aggiunto", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
		}

		private void btnPezzodipollo_Click(object sender, EventArgs e)
		{
			if (!Utilita.controllo_carrello("Arancini"))
			{
				Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Arancini", 1, Image.FromFile(@"Foto/coscia di pollo.jpg"), 4));
				MessageBox.Show("Ordine aggiunto al carrello", "Ordine aggiunto", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
		}
	}
}
