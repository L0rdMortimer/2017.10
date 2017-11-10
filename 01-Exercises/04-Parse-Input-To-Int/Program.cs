using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Parse_Input_To_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere. Olen kalkulaator-programm. Ütle mulle 2 numbrit ja ma ütlen sulle nende summa.");
            Console.Write("\nKirjuta esimene number: ");
            string n1 = Console.ReadLine();
            Console.Write("\nKirjuta teine number: ");
            string n2 = Console.ReadLine();

            int n11 = int.Parse(n1);
            int n22 = int.Parse(n2);

            int sum = n11 + n22;

            Console.WriteLine("\n\nSinu numbrite summa on: " + sum);
            Console.WriteLine("\n\nPress Enter...");
            Console.ReadLine();
        }
    }
}
