using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teeme sulle nimekirja sinu tasku sisust");
            Console.WriteLine("Kirjuta oma eseme nimetus ja vajuta enter. \nKui rohkem asju pole kirjuta \"x\" ");
            List<string> tasku = new List<string>();

            while (true)
            {
                Console.WriteLine("_______________________");
                Console.Write(">");
                string ese = Console.ReadLine();
                
                if (ese != "x")
                {
                    tasku.Add(ese);

                }
                else
                    break;
            }
            Console.WriteLine("Sinu taskutes on: {0} asja",tasku.Count);
            Random rnd = new Random();
            int esex = rnd.Next(tasku.Count);
            Console.WriteLine("Suvaline ese sinu taskust on: "+ tasku[esex]);
            Console.ReadLine();

        }

    }

}


