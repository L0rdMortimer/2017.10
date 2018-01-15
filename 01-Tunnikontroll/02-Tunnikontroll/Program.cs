using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toidu Kodu");
            Console.WriteLine("Kõrvitsa 2, Harjumaa");
            Console.WriteLine("*******************************************");
            while (true)
            {
                Console.Write("Enter price of food item [-1 to quit]:");
                string sisend = Console.ReadLine();
                
                if (sisend == "-1") break;

                {
            }
            Console.WriteLine("*******************************************");

            Console.WriteLine("Subtotal: ");
            //Console.WriteLine("15.00 % Gratuity: €2,53");
            //Console.WriteLine("Total: €14,35");
            Console.ReadLine();



        }
    }
}
