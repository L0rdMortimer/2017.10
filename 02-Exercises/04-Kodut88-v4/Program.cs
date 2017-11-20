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

            Console.Write("\nSina pakud: ");
            string q = Console.ReadLine();
            int q4 = int.Parse(q);


            while (true)
            {
                if (arv < q4)
                {
                    Console.WriteLine("Sinu number on suurem.");
                    return;
                }
                if (arv > q4)
                {
                    Console.WriteLine("Sinu number on väiksem.");
                    return;
                }
                if (arv == q4)
                {
                    Console.WriteLine("Sa arvasid minu numbri.");
                    continue;
                }
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
            }


            

        }
    }
}
