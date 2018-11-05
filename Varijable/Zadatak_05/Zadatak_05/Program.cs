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
            double a, b, c, d = 0;
            double e = 2.71828;
            double rjesenje = 0;

            Console.WriteLine(" ___________________");
            Console.WriteLine("|                   |");
            Console.WriteLine("| a + b * ( c - d ) |");
            Console.WriteLine("| _________________ |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|        e          |");
            Console.WriteLine("|___________________|");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Molim unesite vrijednost od a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Molim unesite vrijednost od b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Molim unesite vrijednost od c:");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Molim unesite vrijednost od d:");
            d = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            rjesenje = ((a + ( b * (c - d))) / e);
            Console.WriteLine("Riješenje zadataka je: " + rjesenje);


        }
    }
}
