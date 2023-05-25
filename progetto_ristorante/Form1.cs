using System.Diagnostics;
using Google.Apis.Auth;
using Google.Apis.PeopleService.v1;
using Google.Apis.Services;
using System;

namespace progetto_ristorante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            Utenti_DB db = new Utenti_DB();
            Utenti u = new Utenti(1, "mudricm1@gmail.com", "Lollo", "Ciaocomeva");
            db.AddUtente(u);
            MessageBox.Show(data.ToString());
        }
    }
}