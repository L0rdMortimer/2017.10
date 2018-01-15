using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Oks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Teeme täringute viskamise programmi.");
            //Console.WriteLine("");
            //ütle täringu tahkude arv
            //ehita vastav täring
            //viska seda täringut
            //ehita uus täring
            //lõpeta


            //////////////////////////////////////////////////////////////

            Console.WriteLine("Mul on mitu täringut.\nd4, d6, d8, d10, d12 ja d20.\nMillist soovid visata?\nLõpetamiseks kirjuta \"0\"");
            Random die = new Random();
            while (true)
            {
                Console.Write(">");
                string soov = Console.ReadLine();
                if (soov == "d4")
                {
                    int d4 = die.Next(1, 5);
                    Console.WriteLine("###");
                    Console.WriteLine("#{0}#", d4);
                    Console.WriteLine("###");
                    Console.WriteLine("____________");

                }
                else if (soov == "d6")
                {
                    int d6 = die.Next(1, 7);
                    Console.WriteLine("###");
                    Console.WriteLine("#{0}#", d6);
                    Console.WriteLine("###");
                    Console.WriteLine("____________");

                }
                else if (soov == "d8")
                {
                    int d8 = die.Next(1, 9);
                    Console.WriteLine("###");
                    Console.WriteLine("#{0}#", d8);
                    Console.WriteLine("###");
                    Console.WriteLine("____________");

                }
                else if (soov == "d10")
                {
                    int d10 = die.Next(1, 11);
                    Console.WriteLine("####");
                    Console.WriteLine("#{0}#", d10);
                    Console.WriteLine("####");
                    Console.WriteLine("____________");

                }
                else if (soov == "d12")
                {
                    int d12 = die.Next(1, 13);
                    Console.WriteLine("####");
                    Console.WriteLine("#{0}#", d12);
                    Console.WriteLine("####");
                    Console.WriteLine("____________");

                }
                else if (soov == "d20")
                {
                    int d20 = die.Next(1, 21);
                    Console.WriteLine("####");
                    Console.WriteLine("#{0}#", d20);
                    Console.WriteLine("####");
                    Console.WriteLine("____________");

                }
                else if (soov == "0") return;

                else
                {
                    Console.WriteLine("Sisesta õige märksõna");
                    Console.WriteLine("____________");
                }
            }

        }
    }
}
