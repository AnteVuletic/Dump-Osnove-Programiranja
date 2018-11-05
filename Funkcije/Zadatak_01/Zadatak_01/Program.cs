using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_01
{
    class Program
    {
        static int Povecaj(int n)
        {
            return n + 10;
        }
        static void Main(string[] args)
        {
            int unesenBroj = 0;
            Console.WriteLine("Unesite jedan broj:");
            unesenBroj = int.Parse(Console.ReadLine());
            Console.WriteLine(Povecaj(unesenBroj));
        }
    }
}
