using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Exxxs
{
    class Program
    {
        static void Main(string[] args)
        {
;            for (int n = 1; n < 6; n++)
            {
                Console.Write("{0}\t",n);
                for (int m = 1; m < 6; m++)
                {
                    Console.Write("{0}\t",n * m);

                }
                Console.WriteLine("");


            }
                Console.ReadLine();
            
        }
    }
}
