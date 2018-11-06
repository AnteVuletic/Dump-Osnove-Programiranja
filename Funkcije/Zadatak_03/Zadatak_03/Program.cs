using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            List<string> listaRijeci = new List<string>();
            listaRijeci = UnesiRijeci();
            Console.WriteLine("Unesite broj slova za ispis rijeci koje imaju vise od tog broja:");
            n = int.Parse(Console.ReadLine());
            ispisRijeci(listaRijeci, n);

        }
        static List<string> UnesiRijeci()
        {
            List<string> listaRijeci = new List<string>();
            int brojacRijeci = -1;
            do {
                Console.WriteLine("Molim unesite rijec ['dosta' za prekid]:");
                listaRijeci.Add(Console.ReadLine());
                brojacRijeci++;
            } while(listaRijeci[brojacRijeci] != "dosta");
            listaRijeci.RemoveAt(brojacRijeci);
            return listaRijeci;
        }
        static void ispisRijeci(List<string> listaRijeci,int brojSolva)
        {
            for(int i=0; i < listaRijeci.Count; i++)
            {
                if(listaRijeci[i].Length > brojSolva)
                {
                    Console.Write(" " + listaRijeci[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
