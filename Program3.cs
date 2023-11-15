using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispit3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi neki broj: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int br1 = 0, br2 = 1,x=0;
           
            for(int i = 2; i < a; i++)
            {
                x = br1 + br2;
                br1 = br2;
                br2 = x;
            }
            Console.WriteLine(a + ". član fibonacijevog niza je: " + x);
            Console.ReadKey();
        }
    }
}
