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
            string recenicaConsola = "";
            Console.WriteLine("Molim unesite recenicu:");
            recenicaConsola = Console.ReadLine();
            Console.WriteLine("Broj samo glasnika je: " + BrojSamoglasnika(recenicaConsola));

        }
        static int BrojSamoglasnika(string recenica)
        {
            int brojacSamoglas = 0;
            for(int i = 0; i < recenica.Length; i++)
            {
                if( IsSamoglasnik(recenica[i]) )
                {
                    brojacSamoglas++;
                }else if(i == 0 && recenica[i] == 'r' && !IsSamoglasnik(recenica[i + 1]))
                {
                    brojacSamoglas++;
                }else if( recenica[i] == 'r' && !IsSamoglasnik(recenica[i-1]) && !IsSamoglasnik(recenica[i + 1]))
                {
                    brojacSamoglas++;
                }
            }
            return brojacSamoglas;
        }
        static bool IsSamoglasnik(char theCharacter)
        {
            if (theCharacter == 'a' ||
               theCharacter == 'e' ||
               theCharacter == 'i' ||
               theCharacter == 'o' ||
               theCharacter == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
