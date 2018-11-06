using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> imena = new List<string>();
            List<int> rezultati = new List<int>();
            List<string> rangLista = new List<string>();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Molim unesite ime za natjecatelja " + (i + 1));
                imena.Add(Console.ReadLine());
                Console.WriteLine("Molim unesite rezultat za natjecatelja " + (i+1));
                rezultati.Add(int.Parse(Console.ReadLine()));
            }
            rangLista = Rangiraj(imena, rezultati);
            Console.WriteLine("Konacna rang lista je:");
            for(int i = 0; i < rangLista.Count; i++)
            {
                Console.WriteLine(rangLista[i]);
            }
        }
        static List<string> Rangiraj(List<string> imena,List<int> rezultati)
        {
            List<string> rangLista = new List<string>();
            int nextBiggest = 0;
            while(imena.Count != 0) { 
                nextBiggest = 0;
                for (int j = 0; j < imena.Count; j++)
                {
                    if(rezultati[nextBiggest] < rezultati[j])
                    {
                        nextBiggest = j;
                    }
                }
                rangLista.Add(imena[nextBiggest] + " " + rezultati[nextBiggest]);
                imena.RemoveAt(nextBiggest);
                rezultati.RemoveAt(nextBiggest);
            }
            return rangLista;
        }
    }
}
