using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitbläk
{
    class Program
    {
        static void Main(string[] args)
        {

            

            while (true)
            {
                Console.Write(">");
                int sum = int.Parse(Console.ReadLine());


                if (sum == 1)
                {
                    Console.WriteLine("vajutasid 1");
                    
                }
                else if (sum == 2)
                {
                    Console.WriteLine("vajutasid 2");

                }
                else
                    break;
            }
            
        }
    }
}

