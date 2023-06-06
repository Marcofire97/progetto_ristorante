using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace progetto_ristorante
{
	public partial class Hamburger : Form
	{
		DateTime data = DateTime.Now;
		public Hamburger()
		{
			InitializeComponent();
		}

		private void pcbTornaHomeHamburger_Click(object sender, EventArgs e)
		{
			new Ristorante().Show();
			this.Hide();
		}

		private void btnCompraBurgerTradizionale_Click(object sender, EventArgs e)
		{
			if (!Utilita.controllo_carrello("Burger tradizionale"))
			{
				Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Burger tradizionale", 1, null, 9));
			}
		}

		private void btnCompraBurgerSpeciale_Click(object sender, EventArgs e)
		{
			if (!Utilita.controllo_carrello("Gusto speciale"))
			{
				Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Gusto speciale", 1, null, 13));
			}
		}

		private void btnCompraBurgerPremium_Click(object sender, EventArgs e)
		{
			if (!Utilita.controllo_carrello("Burger Premium"))
			{
				Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Burger Premium", 1, null, 18));
			}
		}
	}
}
