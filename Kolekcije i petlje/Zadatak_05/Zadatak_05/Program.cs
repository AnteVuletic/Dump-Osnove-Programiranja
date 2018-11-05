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
            List<int> ocjene = new List<int>();
            ocjene.Add(2);
            ocjene.Add(3);
            ocjene.Add(4);
            ocjene.Add(2);
            ocjene.Add(2);
            ocjene.Add(5);
            ocjene.Add(1);
            ocjene.Add(4);
             
            for( int i = 0; i < ocjene.Count; i++)
            {
                if(ocjene[i]%2 == 0)
                {
                    ocjene.RemoveAt(i);
                    i--;
                }
            }
            for(int i = 0; i < ocjene.Count; i++)
            {
                Console.Write(ocjene[i] + " ");
            }
        }
    }
}
