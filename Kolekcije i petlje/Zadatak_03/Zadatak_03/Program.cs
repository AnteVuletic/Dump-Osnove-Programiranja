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
            int sum = 0;
            int unos = 0;
            do
            {
                Console.WriteLine("Unesite broj koji se sumira [za prekid unesite 0:");
                unos = int.Parse(Console.ReadLine());
                sum += unos;
            } while (unos != 0);
            Console.WriteLine("Suma unesenih brojeva je: " + sum);
        }
    }
}
