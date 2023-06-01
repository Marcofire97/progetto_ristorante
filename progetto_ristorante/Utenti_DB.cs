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
			try
			{
				db = new SqlConnection(STRINGA_CONNESSIONE);
			}
			catch(Exception ex)
			{
				MessageBox.Show("Si è verificato un errore nel database", "Errore database", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Environment.Exit(0);
			}
		}

		public List<Utenti> GetUtenti()
		{
			try
			{
				return db.Query<Utenti>("SELECT * FROM Utenti").ToList();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Si è verificato un errore nel database", "Errore database", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		public Utenti GetUtenti(string email)
		{
			try
			{
				return db.Query<Utenti>($"SELECT * FROM Utenti WHERE EMAIL = '{email}'").FirstOrDefault();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Si è verificato un errore nel database", "Errore database", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}


		public void AddUtente(Utenti u)
		{
			try
			{
				db.Execute("INSERT INTO Utenti (EMAIL, USERNAME, PASSWORD) VALUES (@Email, @Username, @Password)", u);
			}
			catch(Exception ex)
			{
				MessageBox.Show("Si è verificato un errore nel database", "Errore database", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void DeleteUtente(Utenti u)
		{
			try
			{
				db.Execute("DELETE FROM Utenti WHERE EMAIL = @Email", u);
			}
			catch(Exception ex)
			{
				MessageBox.Show("Si è verificato un errore nel database", "Errore database", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void UpdateUtente(Utenti u)
		{
			try
			{
				db.Execute("UPDATE Utenti SET EMAIL = @Email, USERNAME = @Username, PASSWORD = @Password WHERE ID = @ID", u);
			}
			catch(Exception ex)
			{
				MessageBox.Show("Si è verificato un errore nel database", "Errore database", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		
	}
}
