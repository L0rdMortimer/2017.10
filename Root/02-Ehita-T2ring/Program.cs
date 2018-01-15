using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ehita_T2ring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teeme täringute viskamise programmi.\nÜtle mitu külge sa soovid et täringul oleks.");

            while (true)
            {
                Console.Write(">");
                int arv = int.Parse(Console.ReadLine());
                if (arv > 0)
                {
                    Console.WriteLine("siin toimub vise");

                }
                else if (arv == 0) return;
                else
                {
                    Console.WriteLine("Kirjuta palun araabia number");
                }
            }
            //ütle täringu tahkude arv
            //ehita vastav täring
            //viska seda täringut
            //ehita uus täring
            //lõpeta


            //////////////////////////////////////////////////////////////

        }
    }
}
