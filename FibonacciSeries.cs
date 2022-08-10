using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class FibonacciSeries
    {
        public static void FbcSeries()
        {
            int a = 0;
            int b = 1;
            int c;
            int i;
            Console.WriteLine("Fibonacci series : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " " + b + " ");
            for (i = 2; i < n; ++i)
            {
                c = a + b;
                Console.WriteLine(c + " ");
                a = b;
                b = c;
            }
        }
    }
}