using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_ristorante
{
	public partial class Delivery : Form
	{
		Ordinazioni_DB db = new Ordinazioni_DB();
		public Delivery()
		{
			InitializeComponent();
		}

		private void pcbTornaHomeDelivery_Click(object sender, EventArgs e)
		{
			new Ristorante().Show();
			this.Hide();
		}

		private void btnTerminaordine_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(StreetTextBox.Text) || string.IsNullOrEmpty(NumberAddressTextBox.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
			{
				MessageBox.Show("Completa bene tutti i campi");
				return;
			}
			foreach(var ordine in Utilita.ordinazioni)
			{
				//db.AddOrdinazione(ordine);
				Utilita.N_acquisti += ordine.Quantita;
			}
			MessageBox.Show("Ordine effettuato");
			Utilita.ordinazioni.Clear();
			Utilita.elementi_carrello.Clear();
			new Ristorante().Show();
			this.Close();
		}
	}
}
