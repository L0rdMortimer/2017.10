using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Kodut88_v4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arva mis number mul on.");
            Random rnd = new Random();
            int arv = rnd.Next(0, 11);


            while (arv == q4)// SIIT ON ERROR KUIDAS TEHA ILMA TRUE/CONTINUE/BREAK süsteemida while asja.
            {
                Console.Write("\nSina pakud: ");
                string q = Console.ReadLine();
                int q4 = int.Parse(q);
                
                if (arv < q4)
                {
                    Console.WriteLine("Sinu number oli Suurem. Proovi veel.");
                }
                if (arv > q4)
                {
                    Console.WriteLine("Sinu number oli väiksem. Proovi veel.");
                }
                if (arv == q4)
                {
                    Console.WriteLine("Õige! Arvasid numbri ära!");
                }
            }
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
