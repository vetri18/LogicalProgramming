using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class PrimeNumber
    {
        public static void PrimeNum()
        {
            int num, i, f = 0;
            Console.Write("Enter a Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    f++;
                }
            }
            if (f == 2)
            {
                Console.WriteLine("Number is Prime");
            }
            else
            {
                Console.WriteLine("Number is not Prime");
            }
        }
    }
}