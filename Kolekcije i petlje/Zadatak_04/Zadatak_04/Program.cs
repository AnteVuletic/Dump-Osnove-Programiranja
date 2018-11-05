using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaStrinogva = new List<string>();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+1 + " rijec");
                listaStrinogva.Add(Console.ReadLine());
            }
            for(int i = 0; i < listaStrinogva.Count; i++)
            {
                if(i%2 == 0)
                {
                    Console.Write(" " + i + ". ");
                    Console.Write(listaStrinogva[i]);
                }
            }

            Console.WriteLine();
            for (int i = 0; i < listaStrinogva.Count; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(" " + i + ". ");
                    Console.Write(listaStrinogva[i]);
                }
            }
            Console.WriteLine();
            for( int i = listaStrinogva.Count; i > 0; i--)
            {
                Console.Write(" " + i + ". ");
                Console.Write(listaStrinogva[i-1]);
            }
            Console.WriteLine();
        }
    }
}
