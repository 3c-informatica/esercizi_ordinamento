using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomi_Binario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cognomi = { "ABALINTOAIE", "ANDRU", "BERRINO", "BRUZZONE", "CERATTO",
                "CHIRIAC", "DALLORTO", "GAMBINO", "GIRAUDO", "GIRELLO", "GJINI",
                "KARDASH", "KOPSHTI", "LERDA", "LUBATTI", "MAGLIANO", "MARTINA", "MO",
                "PETRUCCI", "REALE", "SACCATO", "SINGH", "SIVERA" };

            int n = cognomi.Length;
            ordina(cognomi, n);
            stampa_binario(cognomi, n);


        }

        private static void stampa_binario(string[] cognomi, int n)
        {
            char c;
            string s = "";
            for(int i = 0; i<n; i++)
            {
                s = "";
                string cognome = cognomi[i];
                s = nomeInBinari(cognome);
                Console.WriteLine(cognome.PadRight(15) + s);
            }
        }
        /// <summary>
        /// esamino ogni carattere del nome, lo converto in interoe lo trasformo in binario
        /// </summary>
        /// <param name="cognome"></param>
        /// <returns></returns>
        private static string nomeInBinari(string cognome)
        {
            string s = "";
            char c;
            for(int i = 0; i < cognome.Length; i++)
            {
                c = cognome[i];
                string
            }
        }

        private static void ordina(string[] cognomi, int n)
        {
            throw new NotImplementedException();
        }
    }
}
