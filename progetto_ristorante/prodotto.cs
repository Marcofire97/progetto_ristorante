using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_ristorante
{
	public class prodotto
	{

		public string nome { get; set; }
		public double prezzo { get; set; }
		public int quantita { get; set; }
		public Image immagine { get; set; }

		public prodotto(string nome, double prezzo, int quantita, Image immagine)
		{
			this.nome = nome;
			this.prezzo = prezzo;
			this.quantita = quantita;
			this.immagine = immagine;
		}

	}
}
