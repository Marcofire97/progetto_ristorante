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
    public partial class Delivery : Form
    {
        public Delivery()
        {
            InitializeComponent();
        }

        private void AddressGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void btnVaiAlCarrello_Click(object sender, EventArgs e)
        {
            new Carrello().Show();
            this.Hide();
        }

        private void pcbTornaHomeDelivery_Click(object sender, EventArgs e)
        {
            new Ristorante().Show();
            this.Hide();
        }
    }
}
