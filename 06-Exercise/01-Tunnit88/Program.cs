using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Tunnit88
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervist. Veeretame täringut. Ja vaatame kumb võidab.\n");
            

            while (true)
                {
                    Console.Write("Oled Valmis? :");
                    string vastus1 = Console.ReadLine();
                    
                    if (vastus1 == "jah")
                        {       
                            Console.Write("\nOlgu. Kirjuta viska: ");
                            break;
                        }
                        
                    else
                        Console.WriteLine("Aga nüüd?");
                        continue;

                }
            string vise1=Console.ReadLine();

            if (vise1 == "viska")
                {
                    Random rnd=new Random();
                    int vis1=rnd.Next(1,7);
                    Console.WriteLine($"Viskasid: {vis1}");
                    
                } 

            Console.WriteLine("\n Vägev. Minu kord.");
            Console.WriteLine($"\nMina viskasin {vis1}");

                            




            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }
    }
}