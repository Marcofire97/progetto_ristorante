using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_ristorante
{
    public partial class Offerte : Form
    {
        public Offerte()
        {
            InitializeComponent();
            label3.Text = Utilita.N_acquisti.ToString();
            if (int.Parse(label3.Text) > 5)
            {
                label3.Text = "5";
            }
            if (int.Parse(label3.Text) == 5)
            {
                button1.Enabled = true;
            }

            label6.Text = Utilita.N_acquisti.ToString();
            if (int.Parse(label6.Text) > 10)
            {
                label6.Text = "10";
            }
            if (int.Parse(label6.Text) == 10)
            {
                button2.Enabled = true;
            }

            label9.Text = Utilita.N_acquisti.ToString();
            if (int.Parse(label9.Text) > 20)
            {
                label9.Text = "20";
            }
            if (int.Parse(label9.Text) == 20)
            {
                button3.Enabled = true;
            }
        }

        private void Offerte_Load(object sender, EventArgs e)
        {

        }

        private void pcbTornaHomeTakeAway_Click(object sender, EventArgs e)
        {
            new Ristorante().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilita.bonus_5 = Generatore_codice();
            MessageBox.Show("Il tuo codice per lo sconto di 1€ è: " + Utilita.bonus_5);
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utilita.bonus_10 = Generatore_codice();
            MessageBox.Show("Il tuo codice per lo sconto di 3€ è: " + Utilita.bonus_10);
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Utilita.bonus_20 = Generatore_codice();
            MessageBox.Show("Il tuo codice per lo sconto di 8€ è: " + Utilita.bonus_20);
            button3.Enabled = false;
        }

        private string Generatore_codice()
        {
            const string caratteri = "abcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();

            char[] combinazione = new char[5];
            for (int i = 0; i < 5; i++)
            {
                combinazione[i] = caratteri[random.Next(caratteri.Length)];
            }

            return new string(combinazione);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void lblCarrello_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
