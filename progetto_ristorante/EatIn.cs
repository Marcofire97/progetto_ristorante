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
    public partial class EatIn : Form
    {
        public EatIn()
        {
            InitializeComponent();
        }

        private void pcbTornaHomeEatIn_Click(object sender, EventArgs e)
        {
            new Ristorante().Show();
            this.Hide(); 
        }
    }
}
