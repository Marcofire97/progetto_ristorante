using Google.Apis.PeopleService.v1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_ristorante
{
	public partial class ElementoCarrello : UserControl
	{

		public Ordinazioni pr { get; set; }

		public ElementoCarrello(Ordinazioni pr)
		{
			InitializeComponent();
			this.pr = pr;
			lblquantitàprodotto.Text = "(" + pr.Quantita.ToString() + ")";
			pictureBox1.Image = pr.immagine;
			lblNomeProdotto.Text = pr.Prodotto;
			lblPrezzoProdotto.Text = pr.prezzo.ToString() + "€";

		}
		public Image immagine_prodotto
		{
			get { return pictureBox1.Image; }
			set { pictureBox1.Image = pr.immagine; }
		}

		public string nome_prodotto
		{
			get { return lblNomeProdotto.Text; }
			set { lblNomeProdotto.Text = pr.Prodotto; }
		}

		public int quantita_prodotto
		{
			get
			{
				string quantità = lblquantitàprodotto.Text.Replace("(", "").Replace(")", "");
				return int.Parse(quantità);
			}
			set
			{
				lblquantitàprodotto.Text = "(" + pr.Quantita.ToString() + ")";
			}
		}

		public double prezzo_prodotto
		{
			get
			{
				string prezzo = lblPrezzoProdotto.Text.Replace("€", "");
				return double.Parse(prezzo);
			}
			set { lblPrezzoProdotto.Text = pr.prezzo.ToString() + "€"; }
		}

		private void btnRimuoviProdotto_Click_1(object sender, EventArgs e)
		{
			for(int i=0; i<Utilita.ordinazioni.Count; i++)
			{
				if (Utilita.ordinazioni[i].Prodotto == lblNomeProdotto.Text)
				{
					Utilita.ordinazioni.RemoveAt(i);
					Utilita.elementi_carrello.RemoveAt(i);
					break;
				}
			}
			this.Parent.Controls.Remove(this);
			aggiorna();

		}

		private void pictureBox2_Click_1(object sender, EventArgs e)
		{
			pr.Quantita+=1;
			lblquantitàprodotto.Text = "(" + pr.Quantita.ToString() + ")";
		}

		private void aggiorna()
		{
			new Carrello().Show();
			Carrello carrello = Application.OpenForms.OfType<Carrello>().FirstOrDefault();
			carrello?.Close();
		}
	}
}
