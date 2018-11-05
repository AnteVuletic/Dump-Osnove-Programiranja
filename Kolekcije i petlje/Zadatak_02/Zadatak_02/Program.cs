using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosti brojevi su: ");
            for(int i = 0; i < 100; i++)
            {
                if ((i == 2 && i == 3) || (i % 2 != 0 && i % 3 != 0))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
