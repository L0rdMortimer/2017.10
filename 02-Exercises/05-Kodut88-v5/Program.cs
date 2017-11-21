using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Kodut88_v5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genereerin ühe numbri 1-100. Proovi see ära arvata.\n");

            //Genereeri random number
            Random rnd = new Random();
            int arv = rnd.Next(0, 101);


            while (true)
            {
                //sina pakud
                Console.Write("Sina pakud: ");
                string q = Console.ReadLine();
                int q5 = int.Parse(q);

                if (arv == q5)
                {
                    Console.WriteLine("Arvasid ära, suurepärane.");
                    break;
                }
                if (arv < q5)
                {
                    Console.WriteLine("Sinu number oli suurem. Proovi veel.");
                    continue;
                }
                if (arv > q5)
                {
                    Console.WriteLine("Sinu number oli väiksem. Proovi veel.");
                    continue;
                }
            }
            //exit tekst
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
