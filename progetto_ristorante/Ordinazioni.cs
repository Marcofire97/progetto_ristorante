using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace progetto_ristorante
{
    internal class Ordinazioni
    {

        public int UtenteID { get; set; }
        public string Email { get; set; }
        public string DataOrdine { get; set; }
        public string Prodotto { get; set; }
        public int Quantita { get; set; }

        public Ordinazioni(int utenteID, string Email, string dataOrdine, string prodotto, int quantita)
        {
            this.UtenteID = utenteID;
            this.Email = Email;
            this.DataOrdine = dataOrdine;
            this.Prodotto = prodotto;
            this.Quantita = quantita;
        }

		public Ordinazioni(int utenteID, string dataOrdine, string prodotto, int quantita)
		{
			this.UtenteID = utenteID;
			this.DataOrdine = dataOrdine;
			this.Prodotto = prodotto;
			this.Quantita = quantita;
		}
	}
}

/*
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace SHA256_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passwordplain = "ciao";
            byte[] passwordhashata = HashPassword(passwordplain);

            Console.WriteLine(BitConverter.ToString(passwordhashata).Replace("-", string.Empty));
        }

        static byte[] HashPassword(string passwordClear)
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

 */