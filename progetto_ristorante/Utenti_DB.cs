using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace progetto_ristorante
{
	internal class Utenti_DB
	{
		const string STRINGA_CONNESSIONE = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\39351\\Source\\Repos\\Marcofire97\\progetto_ristorante\\progetto_ristorante\\DATABASE\\UTENTI.mdf;Integrated Security=True";
		private readonly SqlConnection db;

		public Utenti_DB()
		{
			db= new SqlConnection(STRINGA_CONNESSIONE);
		}

		public List<Utenti> GetUtenti()
		{
			return db.Query<Utenti>("SELECT * FROM UTENTI").ToList();
		}


		public void AddUtente(Utenti u)
		{
			db.Execute("INSERT INTO UTENTI (EMAIL, USERNAME, PASSWORD) VALUES (@Email, @Username, @Password)", u);
		}

		public void DeleteUtente(Utenti u)
		{
			db.Execute("DELETE FROM UTENTI WHERE EMAIL = @Email", u);
		}

		public void UpdateUtente(Utenti u)
		{
			db.Execute("UPDATE UTENTI SET EMAIL = @Username, USERNAME = @Username, PASSWORD = @Password WHERE EMAIL = @email", u);
		}
	}
}
