using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Kodut88_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mul on üks number vahemikus 1-100. Arve see ära.");

            int arv = 50;

            Console.Write("Paku oma number: ");
            string q = Console.ReadLine();
            int q2 = int.Parse(q);

            if (arv < q2)
            {
                Console.WriteLine("Sinu number on suurem.");
            }
            if (arv > q2)
            {
                Console.WriteLine("Sinu number on väiksem.");
            }
            if (arv == q2)
            {
                Console.WriteLine("Sa arvasid mu numbri ära. Väga tubli!");
            }
            Console.WriteLine("\nPress Enter...");
            Console.ReadLine();
        }
    }
}
