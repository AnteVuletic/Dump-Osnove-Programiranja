using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = 0;

            Console.WriteLine("Molimo unesite broj za provjeru dali je prost:");
            broj = int.Parse(Console.ReadLine());

            if((broj == 2 && broj == 3) || (broj%2 != 0 && broj%3 != 0))
            {
                Console.WriteLine(broj + " je prost.");
            }
            else
            {
                Console.WriteLine("Nije prost");
            }
        }
    }
}
