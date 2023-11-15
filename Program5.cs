using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispit5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double zbroj = 0;
            double[] polje = { 12, 99, 223, 2, 23.99, 68, 69, 77.5, 31, 3 };

            double avg = Queryable.Average(polje.AsQueryable());

            Console.WriteLine("Srednja vrijednost je: " + avg);
            double naj;
            double najmanji=0, drugi=0;

            for (int i = 0; i < polje.Length; i++)
            {
                Console.WriteLine((Math.Abs(polje[i] - avg)));
                
            }
            
            

            Console.ReadKey();
        }
    }
}
