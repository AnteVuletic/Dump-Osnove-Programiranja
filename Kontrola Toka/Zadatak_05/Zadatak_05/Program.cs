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
            int unesenaGodina = 0;

            Console.WriteLine("Unesite godinu od 1600 nadalje.");
            unesenaGodina = int.Parse(Console.ReadLine());

            if(unesenaGodina >= 1600)
            {
                if((unesenaGodina%4 == 0 && unesenaGodina%400 == 0 ) || unesenaGodina%100 != 0 )
                {
                    Console.WriteLine("Godina je prijestupna.");
                }
                else
                {
                    Console.WriteLine("Godina nije prijestupna");
                }
            }

        }
    }
}
