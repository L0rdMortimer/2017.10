using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Less_Or_Greater_Than
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta üks number ning ütlen kas su number on suurem või väiksem kui minu oma.");
            Console.Write("Sisesta enda number: ");
            string num = Console.ReadLine();
            int nuum = int.Parse(num);

            int arv = 34;

            if (arv > nuum)
            {
                Console.WriteLine("Sinu number on väiksem kui minu oma.");
            }
            if (arv < nuum) 
            {
                Console.WriteLine("Sinu number on suurem kui minu oma.");
            }
            if (arv == nuum)
            {
                Console.WriteLine("Arvasid minu numbri. Väga ootamatu!");
            }
            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}
