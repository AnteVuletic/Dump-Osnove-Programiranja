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
            string choice = "";

            Console.WriteLine(" ___________________________ ");
            Console.WriteLine("|        Mogući odabiri     |");
            Console.WriteLine("| P - Površina Pravokutnika |");
            Console.WriteLine("| K - Površina kvadrata     |");
            Console.WriteLine("| O - Površina kruga        |");
            Console.WriteLine("|___________________________|");

            Console.WriteLine();
            Console.WriteLine("Molimo unesite vaš odabir:");
            choice = Console.ReadLine();

            if(choice == "P")
            {
                double a, b = 0;
                Console.WriteLine(" _____________");
                Console.WriteLine("|             |");
                Console.WriteLine("|     a*b     |");
                Console.WriteLine("|_____________|");
                Console.WriteLine();
                Console.WriteLine("Molim unesite a:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Molim unesite b:");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Površina pravokutnika: " + (a * b));

            }
            else if( choice == "K")
            {
                double a = 0;
                Console.WriteLine(" _____________");
                Console.WriteLine("|             |");
                Console.WriteLine("|     a^2     |");
                Console.WriteLine("|_____________|");
                Console.WriteLine();
                Console.WriteLine("Molim unesite a:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Površina kvadrata: " + (a * a));
            }
            else if (choice == "O")
            {
                double r = 0;
                Console.WriteLine(" _____________");
                Console.WriteLine("|             |");
                Console.WriteLine("|    pi*r^2   |");
                Console.WriteLine("|_____________|");
                Console.WriteLine();
                Console.WriteLine("Molim unesite r:");
                r = double.Parse(Console.ReadLine());
                Console.WriteLine("Površina kvadrata: " + (3.14 * r * r ));
            }
            else
            {
                Console.WriteLine("Vaš unos nije među ponuđenim.");
            }

        }
    }
}
