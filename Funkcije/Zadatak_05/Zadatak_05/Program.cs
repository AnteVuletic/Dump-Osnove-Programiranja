using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaOcjena = new List<int>();
            int choice = 0;

            do
            {
                Console.WriteLine("Unesite ocjene 1-5 [prekid je bilo koji drugi unos]:");
                choice = int.Parse(Console.ReadLine());
                listaOcjena.Add(choice);
            } while (choice >= 1 && choice <=5);
            listaOcjena.RemoveAt(listaOcjena.Count-1);
            Console.WriteLine("Prosjek ocjena je: " + Prosjek(listaOcjena));
        }
        static double Prosjek(List<int> ocjene)
        {
            double prosjekOcjena = 0;
            for(int i = 0; i < ocjene.Count; i++)
            {
                prosjekOcjena += ocjene[i];
            }
            return prosjekOcjena / ocjene.Count;
        }
    }
}
