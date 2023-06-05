using Google.Apis.PeopleService.v1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private Ordinazioni pr { get; set; }

        /*public ElementoCarrello(Ordinazioni pr)
		{
			InitializeComponent();
			this.pr = pr;
		} 
		public Image immagine_prodotto
		{
			get { return pictureBox1.Image; }
			set { pictureBox1.Image = pr.immagine ; }
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



		private void btnRimuoviProdotto_Click(object sender, EventArgs e)
		{
			this.Parent.Controls.Remove(this);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
		}

		*/
    }
}
