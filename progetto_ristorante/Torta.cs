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
    public partial class Torta : Form
    {
        DateTime data = DateTime.Now;
        public Torta()
        {
            InitializeComponent();
        }

        private void pcbTornaHomeTorte_Click(object sender, EventArgs e)
        {
            new Collezione().Show();
            this.Hide();
        }

        private void btnCompraTortaGialla_Click(object sender, EventArgs e)
        {
            if (!Utilita.controllo_carrello("Torta Gialla"))
            {
                Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Torta Gialla", 1, null, 18));
            }
        }

        private void btnCompraTortaVerde_Click(object sender, EventArgs e)
        {
            if (!Utilita.controllo_carrello("Torta Verde"))
            {
                Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Torta Verde", 1, null, 12));
            }
        }

        private void btnCompraTortaRosa_Click(object sender, EventArgs e)
        {
            if (!Utilita.controllo_carrello("Torta Rosa"))
            {
                Utilita.ordinazioni.Add(new(Utilita.id_utente, data.ToString(), "Torta Rosa", 1, null, 23));
            }
        }
    }
}
