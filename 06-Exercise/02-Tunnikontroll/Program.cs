using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toidupuu");
            Console.WriteLine("44 Kure tee");

            Console.WriteLine("____________________________________");
            Console.WriteLine("Toode nr 1 .Kilu - hind 4.23€");
            Console.WriteLine("Toode nr 2 .Leib - hind 2.11€");
            Console.WriteLine("Toode nr 3 .Viin - hind 6.97€");
            Console.WriteLine("Toode nr 4 .Või  - hind 1.54€");
            Console.WriteLine("_____________________________________");
            while (true)
            {
                Console.Write("\nVali toote number mida soovid osta: ");
                string[] inv = new string[5];
                inv[0] = 0
                inv[1] = 4.23€
                inv[2] = 2.11€
                inv[3] = 6.97€
                inv[4] = 1.54€ 
                string ost = Console.ReadLine();
                int valik = int.Parse(ost);
                if (valik == 1);
                {
                    Console.WriteLine("maksa" + inv[valik]);
                    continue;
                }
                    

                else (valik == "kõik");
                    break;








               
                
                }



            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
