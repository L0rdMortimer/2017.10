using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_First_User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere. Olen papakoi programm. Ütle midagi ja ütlen selle sulle tagasi\n");
            Console.Write("Sina ütled: ");  // Write jätab user input kirjutamise samale reale kus tekst on. WriteLine laseb kirjutada prinditud rea alla.
                                            //teksti ja user inputi vahele ei tule reavahet kui ise seda eraldi sisse ei kirjuta. järgmine rida tuleb käsuga mis lõppeb _Line

                                            // \n saab kasutada ainult "" vahel  

            string say = Console.ReadLine();

            Console.WriteLine("\nMina ütlen: " + say); // \n saab kasutada järjest mitu korda kui vaja mitu reavahet jätta
            Console.WriteLine("\n\nPress Enter...");
            Console.ReadLine();
        }
    }
}