using Dapper;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace progetto_ristorante
{
    internal class Ordinazioni_DB
    {
        const string STRINGA_CONNESSIONE = "workstation id=Ristorante.mssql.somee.com;packet size=4096;user id=Lollone1234_SQLLogin_1;pwd=9ecwjxal7u;data source=Ristorante.mssql.somee.com;persist security info=False;initial catalog=Ristorante";
        private readonly SqlConnection db;

        public Ordinazioni_DB()
        {
			try
			{
				db = new SqlConnection(STRINGA_CONNESSIONE);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Si è verificato un errore nel database", "Errore database", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Environment.Exit(0);
			}
		}

        public List<Ordinazioni> GetOrdinazioni()
        {
            try
            {
				return db.Query<Ordinazioni>("SELECT * FROM Ordinazioni").ToList();
			}
            catch(Exception ex)
            {
				MessageBox.Show("Si è verificato un errore nel database", "Errore database", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
        }

        public List<Ordinazioni> GetOrdinazioni(Ordinazioni o)
        {
            try
            {
				return db.Query<Ordinazioni>($"SELECT * FROM Ordinazioni WHERE UtenteID = '{o.UtenteID}'").ToList();
			}
            catch(Exception ex)
            {
				MessageBox.Show("Si è verificato un errore nel database", "Errore database", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}

        }

        public void AddOrdinazione(Ordinazioni o)
        {
			try
			{
				db.Execute($"INSERT INTO Ordinazioni (UtenteID, Email, DataOrdine, Prodotto, Quantita) VALUES (@UtenteID, (SELECT EMAIL FROM Utenti WHERE ID = @UtenteID), @DataOrdine, @Prodotto, @Quantita)", o);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Si è verificato un errore nel database", "Errore database", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
      
    }
}
