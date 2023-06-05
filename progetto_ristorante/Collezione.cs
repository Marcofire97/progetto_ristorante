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
    public partial class Collezione : Form
    {
        public Collezione()
        {
            InitializeComponent();
        }

        private void btnTwitterCollezione_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "explorer.exe",
                Arguments = "https://twitter.com"
            };

            System.Diagnostics.Process.Start(psi);
        }

        private void btnInstagramCollezione_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "explorer.exe",
                Arguments = "https://instagram.com"
            };

            System.Diagnostics.Process.Start(psi);
        }

        private void btnFacebookCollezione_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "explorer.exe",
                Arguments = "https://facebook.com"
            };

            System.Diagnostics.Process.Start(psi);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ShoppingCart_Click(object sender, EventArgs e)
        {
            new Carrello().Show();
            this.Hide();
        }

        private void btnVaiallaCollezione_Click(object sender, EventArgs e)
        {
            new Collezione().Show();
            this.Hide();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            new Ristorante().Show();
            this.Hide();
        }

        private void btnVaiEatIn_Click(object sender, EventArgs e)
        {
            new EatIn().Show();
            this.Hide();
        }

        private void TakeButton_Click(object sender, EventArgs e)
        {
            new TakeAway().Show();
            this.Hide();
        }

        private void btnVaiOfferte_Click(object sender, EventArgs e)
        {
            new Offerte().Show();
            this.Hide();
        }

        private void btnVaiAlleImpostazioni_Click(object sender, EventArgs e)
        {
            new Cliente().Show();
            this.Hide();
        }

        private void btnHamburger_Click(object sender, EventArgs e)
        {
            new Hamburger().Show();
            this.Hide();
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            new Pasta().Show();
            this.Hide();
        }

        private void btnTorta_Click(object sender, EventArgs e)
        {
            new Torta().Show();
            this.Hide();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            new Pizza().Show();
            this.Hide();
        }
    }
}
