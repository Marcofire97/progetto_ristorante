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

		public List<Utenti> get_utenti()
		{
			return db.Query<Utenti>("SELECT * FROM UTENTI").ToList();
		}
	}
}
