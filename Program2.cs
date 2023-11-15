using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispit2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string abeceda = "abcčćdđefghijklmnoprsštuvzžxy";
            ponovo: Console.Write("Unesi nesto: ");
            string[] rijec1 = Console.ReadLine();

            Console.Write("Unesi nesto: ");
            string []rijec2 = Console.ReadLine();

            if(rijec1==rijec2)
            {
                Console.WriteLine("Unijeli ste dvije iste rijeci pokusajte ponovo.");
                goto ponovo;
            }

            for(int i = 0; ; i++)
            {
                if (rijec1[i] != rijec2[i])
                {
                    int x1 = abeceda.IndexOf(rijec1[i]);
                    int x2 = abeceda.IndexOf(rijec2[i]);

                    if(x1 > x2)
                    {
                        Console.WriteLine(rijec2 + " " + rijec1);
                    }
                    else
                    {
                        Console.WriteLine(rijec1 + " " + rijec2);
                    }
                }
            }
            
            Console.ReadKey();
        }
    }
}
