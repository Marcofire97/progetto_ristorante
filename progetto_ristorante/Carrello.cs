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
		/*
		DateTime data = DateTime.Now;
		Ordinazioni ord1;
		Ordinazioni ord2;
		*/
		public Carrello()
		{
			InitializeComponent();

			//TOGLI I COMMENTI MULTIRIGA PER TESTARE (Ogni ordine va distanziato di 50 pixel l'uno dall'altro)

			/*
			ord1 = new Ordinazioni(1, data.ToString(), "Prosciutto", 2, null, 4);
			ord2 = new Ordinazioni(2, data.ToString(), "Prosciutto crudo", 5, null, 5);
			ElementoCarrello elem1 = new ElementoCarrello(ord1);
			elem1.Location = new Point(20, 50);
			ElementoCarrello elem2 = new ElementoCarrello(ord2);
			elem2.Location = new Point(20, 100);
			groupBox1.Controls.Add(elem1);
			groupBox1.Controls.Add(elem2);
			*/

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
			if(Utilita.elementi_carrello.Count>0)
			{
				button1.Enabled = true;
			}
		}

		private void pcbTornaHomeCarrello_Click(object sender, EventArgs e)
		{
			new Ristorante().Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new Delivery().Show();
			this.Hide();
		}
	}
}
