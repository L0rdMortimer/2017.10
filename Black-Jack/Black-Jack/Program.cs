using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Tere, mängime natuke Blackjacki.\n");

            Console.WriteLine("Alustamiseks kirjuta 1\nLõpetamiseks kirjuta 2 ");
            Console.Write(">");

            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("******************************");

            while (true)
            {
                if (s1 == 1)
                {
                    Random deck = new Random();

                    int p1 = deck.Next(2, 12);
                    int p2 = deck.Next(2, 12);
                    Console.WriteLine("\nSul on {0} ja {1}", p1, p2);
                    int p0 = p1 + p2;
                    Console.WriteLine("Kokku {0} punkti", p0);

                    //nidunadu nii

                    int m1 = deck.Next(2, 12);
                    int m2 = deck.Next(2, 12);
                    Console.WriteLine("\nMajal on # ja " + m2);
                    int m0 = m1 + m2;
                    Console.WriteLine("******************************");




                    while (true)
                    {
                        Console.WriteLine("\nLisa kaart :1 \nJää :2");
                        Console.Write(">");

                        int s2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("******************************");
                        if (s2 == 1)
                        {
                            int p3 = deck.Next(2, 12);
                            if (21 < p0 + p3)
                            {
                                Console.WriteLine("\nSaid juurde " + p3);
                                p0 = p0 + p3;

                                Console.WriteLine("{0} Lõhki!", p0);
                                Console.WriteLine("\nMaja võitis!");
                                Console.WriteLine("******************************");
                                Console.WriteLine("\nMängid veel?\nJah :1 \nEi :2");
                                Console.Write(">");
                                int s3 = int.Parse(Console.ReadLine());


                                if (s3 == 1)
                                {
                                    Console.WriteLine("******************************");
                                    Console.WriteLine("***********UUS MÄNG***********");
                                    Console.WriteLine("******************************");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Tänan mängimast!");
                                    Console.ReadLine();
                                    return;
                                }
                            }

                            else
                            {
                                Console.WriteLine("\nSaid juurde " + p3);
                                p0 = p0 + p3;

                                Console.WriteLine("Sul on kokku {0}", p0);
                                Console.WriteLine("******************************");
                            }
                        }
                        else if (s2 == 2)
                        {
                            if (p0 <= m0)
                            {
                                Console.WriteLine("\nMajal on {0} ({1} ja {2}) \nMaja võit!", m0,m1,m2);
                                Console.WriteLine("******************************");
                            }
                            else
                            {
                                Console.WriteLine("\nMajal oli {0} ({1} ja {2}) \nSinu Võit!", m0,m1,m2);
                                Console.WriteLine("******************************");

                            }
                            Console.WriteLine("\nMängid veel?\nJah :1 \nEi :2");
                            Console.Write(">");
                            int s3 = int.Parse(Console.ReadLine());


                            if (s3 == 1)
                            {
                                Console.WriteLine("******************************");
                                Console.WriteLine("***********UUS MÄNG***********");
                                Console.WriteLine("******************************");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Tänan mängimast!");
                                Console.ReadLine();
                                return;
                            }

                        }

                    }
                    continue;


                }
                else if (s1 == 2)
                {
                    Console.WriteLine("Olgu, ise tead.");

                }

                Console.ReadLine();
                break;
            }


        }
    }
}
