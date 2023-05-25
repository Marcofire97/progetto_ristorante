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
            db = new SqlConnection(STRINGA_CONNESSIONE);
        }

        public List<Ordinazioni> GetOrdinazioni()
        {
            return db.Query<Ordinazioni>("SELECT * FROM Ordinazioni").ToList();
        }

        public List<Ordinazioni> GetOrdinazioni(Ordinazioni o)
        {
            return db.Query<Ordinazioni>($"SELECT * FROM Ordinazioni WHERE UtenteID = '{o.UtenteID}'").ToList();
        }

        public void AddOrdinazione(Ordinazioni o)
        {
            db.Execute("INSERT INTO Ordinazioni (UtenteID, DataOrdine, Prodotto, Quantita) VALUES (@UtenteID, @DataOrdine, @Prodotto, @Quantita)", o);
        }
      
    }
}
