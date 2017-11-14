using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Parse_Input_Multiply_Divide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olen kalkulaator programm. Ütle mulle kaks numbrit ning ma korrutan ja jagan need omavahel.\n");
            Console.Write("Sisesta esimene number: ");
            string nr1 = Console.ReadLine();
            int nr11 = int.Parse(nr1);
            Console.Write("\nSisesta teine number: ");
            string nr2 = Console.ReadLine();
            int nr22 = int.Parse(nr2);
            int jagatis = (nr11 / nr22);
            //int korrutis = (nr11 * nr22);
            Console.WriteLine($"\n\nSinu numbrite {nr1} ja {nr2} jagatis on {jagatis}\n");  // aga kuidas saab tehteid teha ilma et peaks neid intima. ??
            Console.WriteLine($"Sinu numbrite {nr11} ja {nr22} korrutis on {nr11*nr22}\n"); // võib panna ka tehte asemele selle {korrutis}

            Console.WriteLine("Press Enter...");
            Console.ReadLine();

        }
    }
}
