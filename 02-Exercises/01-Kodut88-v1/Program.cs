using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Kodut88_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valisin ühe suvalise numbri vahemikus 1-100, proovi see ära arvata.");
            Console.Write("Sisesta number: ");
            int arv = 87;
            string q = Console.ReadLine();
            int q1 = int.Parse(q);

            if (arv < q1)
            {
                Console.WriteLine("\nSinu arv on suurem.");
            }
            if (arv > q1)
            {
                Console.WriteLine("\nSinu arv on väiksem.");
            }

            Console.WriteLine("\nPress Enter...");
            Console.ReadLine();


        }
    }
}
