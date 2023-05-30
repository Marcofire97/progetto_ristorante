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
	internal class Utenti
	{
        public int ID { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

		public Utenti(int iD, string email, string username, string password)
		{
			this.ID = iD;
			this.Email = email;
			this.Username = username;
			this.Password = password;
		}

		public Utenti(string email, string username, string password)
		{
			byte[] passwordhashata = HashPassword(password);
			string passwordhashatastring = BitConverter.ToString(passwordhashata).Replace("-", string.Empty);
			this.Email = email;
			this.Username = username;
			this.Password = passwordhashatastring;
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
