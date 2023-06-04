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
        }

        private void pcbTornaHomeCarrello_Click(object sender, EventArgs e)
        {
            new Ristorante().Show();
            this.Hide();
        }
    }
}
