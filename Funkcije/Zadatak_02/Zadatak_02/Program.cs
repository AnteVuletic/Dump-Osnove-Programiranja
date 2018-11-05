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
            int unesenBrojJedan, unesenBrojDva = 0;
            List<int> allDevidable = new List<int>();
            Console.WriteLine("Unesite prvi broj:");
            unesenBrojJedan = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj:");
            unesenBrojDva = int.Parse(Console.ReadLine());
            allDevidable = SviDjeljivi(unesenBrojJedan, unesenBrojDva);
            Console.WriteLine("Svi djeljivi su: ");
            for(int i = 0; i < allDevidable.Count; i++)
            {
                Console.Write(" " + allDevidable[i] + " ");
            }
            Console.WriteLine();
        }  
        static bool JeliDjeljiv(int prvi, int drugi)
        {
            if (prvi % drugi == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static List<int> SviDjeljivi(int prvi, int drugi)
        {
            List<int> allNummbersDevidable = new List<int>();
            for(int i = 1; i <= prvi; i++)
            {
                if(JeliDjeljiv(drugi,i))
                {
                    allNummbersDevidable.Add(i);
                }
            }
            return allNummbersDevidable;
        }

    }
}
