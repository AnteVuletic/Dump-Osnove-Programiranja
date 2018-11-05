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
            int uneseniBroj = 0;

            Console.WriteLine("Molimo unesite broj izmedu 0-1000");
            uneseniBroj = int.Parse(Console.ReadLine());

            if(uneseniBroj < 1000)
            {
                if(uneseniBroj < 10)
                {
                    Console.WriteLine("Broj je jednoznamenkast");
                }else if(uneseniBroj < 100)
                {
                    Console.WriteLine("Broj je dvoznamenkast");
                }
                else
                {
                    Console.WriteLine("Broj je troznamenkast");
                }
            }
            else
            {
                Console.WriteLine("Broj mora biti izmedu 0-1000");
            }
        }
    }
}
