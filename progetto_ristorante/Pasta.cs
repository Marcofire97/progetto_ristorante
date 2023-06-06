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
    public partial class Pasta : Form
    {
        DateTime data = DateTime.Now;
        public Pasta()
        {
            InitializeComponent();
        }

        private void pcbTornaHomePasta_Click(object sender, EventArgs e)
        {
            new Collezione().Show();
            this.Hide();
        }

        private void btnCompraOraPizza_Click(object sender, EventArgs e)
        {
            if (!Utilita.controllo_carrello("Pizza"))
            {
                Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Pizza", 1, null, 2));
            }
        }

        private void btnCompraOraLasagna_Click(object sender, EventArgs e)
        {
            if (!Utilita.controllo_carrello("Lasagna"))
            {
                Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Lasagna", 1, null, 10));
            }
        }

        private void btnCompraOraSpaghetti_Click(object sender, EventArgs e)
        {
            if (!Utilita.controllo_carrello("Spaghetti"))
            {
                Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Spaghetti", 1, null, 8.99));
            }
        }
    }
}
