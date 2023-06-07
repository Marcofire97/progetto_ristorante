using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_ristorante
{
	public partial class Carrello : Form
	{
		public Carrello()
		{
			InitializeComponent();


			Utilita.elementi_carrello.Clear();

			for (int i = 0; i < Utilita.ordinazioni.Count; i++)
			{
				Utilita.elementi_carrello.Add(new(Utilita.ordinazioni[i]));
			}
			int x = 20;
			int y = 50;
			foreach (var ordine in Utilita.elementi_carrello)
			{
				ordine.Location = new Point(x, y);
				groupBox1.Controls.Add(ordine);
				y += 50;
			}
			if (Utilita.elementi_carrello.Count > 0)
			{
				button1.Enabled = true;
			}
			double prezzo_totale = 0;
			foreach (var ordine in Utilita.ordinazioni)
			{
				prezzo_totale += ordine.Quantita * ordine.prezzo;
			}
			prezzo.Text = prezzo_totale.ToString() + "€";
		}

		private void pcbTornaHomeCarrello_Click(object sender, EventArgs e)
		{
			new Ristorante().Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new Delivery().Show();
			this.Close();
		}
	}
}
