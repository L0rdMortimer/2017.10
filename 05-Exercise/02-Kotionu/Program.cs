using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Kotionu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)// WHile commandi juurde tuleb tagasi kui on continueni jõudnud.
            {
                Console.Write("Jõuluvana kott. kirjuta üks väike number: ");//jõuluvana kotisisu programm
                string[] inv = new string[5] { "kivi", "käärid", "nui", "nuga", "sokk" };
                string num = Console.ReadLine();
                int num1 = int.Parse(num);
                if (num1 < 5)
                {
                    Console.WriteLine("\nPalju õnne, tõmbasit kotist eseme: " + inv[num1]);
                    break;
                }
                else
                    Console.WriteLine("\nLiiga suur number. Proovi väiksemat.\n");
                continue;
            }
            //võta kotist rändom ese.
            //Tänane kingitus on:
            Console.WriteLine("\nPress Enter...");
            Console.ReadLine();
        }
    }
}
