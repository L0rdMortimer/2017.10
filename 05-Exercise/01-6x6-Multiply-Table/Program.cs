using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_6x6_Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n < 7; n++)
            {
                Console.Write("{0}\t", n);
                for (int m = 1; m < 7; m++)
                {
                    Console.Write("{0}\t", n * m);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
