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
            int prviBroj = 5;
            int drugiBroj = 3;

            if(prviBroj%2 == 0){
                prviBroj += drugiBroj;
            }else {
                prviBroj -= drugiBroj;
            }

            Console.WriteLine("Konačno rješenje: " + prviBroj);

        }
    }
}
