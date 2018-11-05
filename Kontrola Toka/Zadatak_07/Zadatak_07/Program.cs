using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "Ante";
            string password = "1234";

            Console.WriteLine("Molimo unesite username:");
            username = Console.ReadLine();
            Console.WriteLine("Molimo unesite password:");
            password = Console.ReadLine();

            if (username == "Ante" && password == "1234")
            {
                int brojJedan, brojDva, brojTri = 0;

                Console.WriteLine("Unesite prvi broj:");
                brojJedan = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite drugi broj:");
                brojDva = int.Parse(Console.ReadLine());
                Console.WriteLine("Unesite treci broj:");
                brojTri = int.Parse(Console.ReadLine());

                if (brojJedan > brojDva && brojJedan > brojTri)
                {
                    if (brojDva > brojTri)
                    {
                        Console.WriteLine(brojTri + "," + brojDva + "," + brojJedan); ;
                    }
                    else
                    {
                        Console.WriteLine(brojDva + "," + brojTri + "," + brojJedan);
                    }
                }
                else if (brojDva > brojJedan && brojDva > brojTri)
                {
                    if (brojTri > brojJedan)
                    {
                        Console.WriteLine(brojJedan + "," + brojTri + "," + brojDva);
                    }
                    else
                    {
                        Console.WriteLine(brojTri + "," + brojJedan + "," + brojDva);
                    }
                }
                else
                {
                    if (brojDva > brojJedan)
                    {
                        Console.WriteLine(brojJedan + "," + brojDva + "," + brojTri);
                    }
                    else
                    {
                        Console.WriteLine(brojDva + "," + brojJedan + "," + brojTri);
                    }
                }
            }
            else
            {
                Console.WriteLine("Proooomašaj.");
            }
        }
    }
}
