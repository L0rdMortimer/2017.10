using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Kodut88_v3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genereerin ühe suvalise numbri 1-10. Provi see ära arvata.");
            Random rnd = new Random();
            int arv = rnd.Next(0, 11);
            Console.Write("Mis sa pakud? : ");
            string q = Console.ReadLine();
            int q3 = int.Parse(q);

            if (arv < q3)
            {
                Console.WriteLine("Sinu number oli suurem.");
            }
            if (arv > q3)
            {
                Console.WriteLine("Sinu number oli väiksem.");
            }
            if(arv ==q3)
            {
                Console.WriteLine("Sa arvasid numbri ära. Hurraa!");
            }
            Console.WriteLine("\nPress Enter...");
            Console.ReadLine();


        }
    }
}
