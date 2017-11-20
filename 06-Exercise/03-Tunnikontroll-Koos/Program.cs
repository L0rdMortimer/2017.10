using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Tunnikontroll_Koos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Toidupuu");
            Console.WriteLine("44 Kure tee");

            double total = 0;
            while (true)
            {
                Console.Write("Toode nr 1 - hind ");
                string ost = Console.ReadLine();



                double value = double.Parse(ost);



                if (value == -1)
                    break;
                total = total + value;
            }
                double viis = total * (double)0.15;
                double kogu = total * (double)0.85;
            
            Console.WriteLine("____________________________________");
            Console.WriteLine($"Toode nr 1 - hind {total}€");
            Console.WriteLine($"15% hinnast - {viis}€");
            Console.WriteLine($"Allahindlus hind - {kogu}");
            Console.WriteLine("_____________________________________");

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
