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
    public partial class Pizza : Form
    {
        DateTime data = DateTime.Now;
        public Pizza()
        {
            InitializeComponent();
        }

        private void pcbTornaHomePizza_Click(object sender, EventArgs e)
        {
            new Collezione().Show();
            this.Hide();
        }

        private void btnCompraPizzaVegana_Click(object sender, EventArgs e)
        {
            if (!Utilita.controllo_carrello("Pizza vegana"))
            {
                Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Pizza vegana", 1, Image.FromFile(@"Foto/pizza vegetariana.jpg"), 12));
				MessageBox.Show("Ordine aggiunto al carrello", "Ordine aggiunto", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
        }

        private void btnCompraPizzaPeperoni_Click(object sender, EventArgs e)
        {
            if (!Utilita.controllo_carrello("Pizza al salame"))
            {
                Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Pizza al salame", 1, Image.FromFile(@"Foto/pizza salame.jpg"), 9));
				MessageBox.Show("Ordine aggiunto al carrello", "Ordine aggiunto", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
        }

        private void btnCompraPizzaHawaii_Click(object sender, EventArgs e)
        {
            if (!Utilita.controllo_carrello("Pizza Hawaii"))
            {
                Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Pizza Hawaii", 1, Image.FromFile(@"Foto/pizza hawaii.jpg"), 11));
				MessageBox.Show("Ordine aggiunto al carrello", "Ordine aggiunto", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
        }
    }
}
