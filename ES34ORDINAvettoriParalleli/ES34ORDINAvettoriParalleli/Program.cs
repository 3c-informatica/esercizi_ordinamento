using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES34ORDINAvettoriParalleli
{
    internal class Program
    {
        static Random rnd= new Random();
        static void Main(string[] args)
        {
            int n;
            string[] nominativi = { "PIETRO", "PIT", "SANDRO", "ELIA", "CAROL", "SAMUELE", 
                "SAMU2","NICOLO'" };
            n = nominativi.Length;
            int[]punti = new int[n];
            caricarePunti(punti);
            stampa(nominativi, punti);
            Console.WriteLine("ORDINAMENTO IN BASE AI PUNTI");
            ordinare(nominativi,punti);
            stampa(nominativi,punti);

            Console.WriteLine(stampa_parimeritro(nominativi, punti));
            Console.ReadKey();
        }

        private static string stampa_parimeritro(string[] nominativi, int[] punti)
        {
            string vincitori = nominativi[0] +"\n";
            int count = 1;
            while (punti[count -1] == punti[count])
            {
                vincitori += (nominativi[count] + "\n");
                count++;
            }

            return vincitori;
        }

        private static void ordinare(string[] nomi, int[] punti)
        {
            int i, j, posMax;
            int temp1;
            string temp2;
            for ( i = 0; i < punti.Length-1; i++)
            {
                posMax = i;
                for (j = i+1; j < punti.Length; j++)
                {
                    if (punti[j] > punti[posMax])
                        posMax = j;

                }
                if (posMax!=i)
                {
                    //scambio punti
                    temp1= punti[i];
                    punti[i] = punti[posMax];
                    punti[posMax]= temp1;
                    //scambio nomi
                    temp2 = nomi[i];
                    nomi[i] = nomi[posMax];
                    nomi[posMax] = temp2;
                }
            }
        }

        private static void stampa(string[] nominativi, int[] punti)
        {
            //STAMPA SU 2 COLONNE, NOMI ALLINEATI A SX E PUNTI A DX
            for (int i = 0; i < punti.Length; i++)
            {
                Console.Write(nominativi[i].PadRight(15,'.')+
                    punti[i].ToString().PadLeft(4));
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void caricarePunti(int[] punti)
        {
            for (int i = 0;i < punti.Length;i++) 
                punti[i] = rnd.Next(0,2);
        }
    }
}
