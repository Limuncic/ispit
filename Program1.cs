using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi jednu rečenicu: ");
            string recenica = Console.ReadLine();
            
            Console.WriteLine(recenica.Replace(' ', '_'));


            Console.ReadKey();

        }
    }
}
