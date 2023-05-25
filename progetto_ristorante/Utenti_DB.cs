using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace progetto_ristorante
{
	internal class Utenti_DB
	{
		const string STRINGA_CONNESSIONE = "workstation id=Ristorante.mssql.somee.com;packet size=4096;user id=Lollone1234_SQLLogin_1;pwd=9ecwjxal7u;data source=Ristorante.mssql.somee.com;persist security info=False;initial catalog=Ristorante";
		private readonly SqlConnection db;

		public Utenti_DB()
		{
			db = new SqlConnection(STRINGA_CONNESSIONE);
		}

		public List<Utenti> GetUtenti()
		{
			return db.Query<Utenti>("SELECT * FROM Utenti").ToList();
		}

		public List<Utenti> GetUtenti(Utenti u)
		{
			return db.Query<Utenti>($"SELECT * FROM Utenti WHERE EMAIL = '{u.Email}'").ToList();
		}


		public void AddUtente(Utenti u)
		{
			byte[] passwordhashata = HashPassword(u.Password);
			u.Password = passwordhashata.ToString();
			db.Execute("INSERT INTO Utenti (EMAIL, USERNAME, PASSWORD) VALUES (@Email, @Username, @Password)", u);
		}

		public void DeleteUtente(Utenti u)
		{
			db.Execute("DELETE FROM Utenti WHERE EMAIL = @Email", u);
		}

		public void UpdateUtente(Utenti u)
		{
			db.Execute("UPDATE Utenti SET EMAIL = @Email, USERNAME = @Username, PASSWORD = @Password WHERE ID = @ID", u);
		}

		private byte[] HashPassword(string passwordClear)
		{
			using (SHA256 hash = SHA256.Create())
			{
				byte[] passwordBytes = Encoding.UTF8.GetBytes(passwordClear);
				byte[] hashBytes = hash.ComputeHash(passwordBytes);

				return hashBytes;
			}
		}
	}
}
