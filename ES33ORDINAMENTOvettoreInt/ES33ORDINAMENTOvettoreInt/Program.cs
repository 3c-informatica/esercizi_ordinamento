using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES33ORDINAMENTOvettoreInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ordinare in ordine crescente il seguente vettore
            int n;
            int[] vettore = { 20, 40, 10, 5, 100, 80, 1, 34, 11 };
            n= vettore.Length;
            Console.WriteLine("VETTORE INIZIALE");

            stampa(vettore, n);
            ordina(vettore, n);
            Console.WriteLine("VETTORE ORDINATO CON ORDINAMENTO PER SELEZIONE");
            stampa(vettore, n);
            Console.ReadKey();
        }

        private static void ordina(int[] vet, int n)
        {
            //var locali
            int i, j; //x i 2 cicli for
            int posMin;//salvo la posizione del numero + piccolo da i in poi
            int temp; //x scambiare il valore dei 2 elementi non in ordine
            for (i = 0; i < n-1; i++)  //esamina gli elementi del vettore dal 1° al penultimo
                                       //ultimo sarà già al posto giusto
            {
                posMin = i;             //salvo la posizione
                for (j = i+1; j < n; j++) //confronto l'elemento in posizione i
                                           //con quelli successivi
                {
                    if (vet[j] <vet[posMin]) //se ne trovo 1 minore ne salvo la poszione
                        posMin = j;
                }
                if (posMin!=i)    //se ho trovato 1 numero + piccolo faccio lo scambio
                {
                    temp = vet[i];
                    vet[i]= vet[posMin]; 
                    vet[posMin] = temp;
                }
            }
        }

        private static void stampa(int[] vettore, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(vettore[i].ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
