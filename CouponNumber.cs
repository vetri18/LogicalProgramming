using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    internal class CouponNumber
    {
        public static void Coupon()
        {
            int counter = 0, temp;

            Console.WriteLine("How Many Cupons Need To Generate: ");
            int cuponNum = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            //list cration
            List<int> check = new List<int>();
            Console.WriteLine("Your Cupone codes are:");
            while (check.Count < cuponNum)
            {
                //plus 10 is given because if user ask for more cupons then loop will get in infinite loop
                temp = random.Next(10 + cuponNum);
                //Console.WriteLine(temp);
                //contains used to take unique number
                if (!check.Contains(temp))
                {
                    Console.WriteLine(temp);
                    check.Add(temp);

                }
                counter++;

            }
            Console.WriteLine("Total tries: " + counter);
            Console.Write("Cupon codes are: ");
        }
    }
}