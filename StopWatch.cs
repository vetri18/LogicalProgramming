using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicalProgramming
{
    internal class StopWatch
    {
        public static void ElapsedTime()
        {
            //Created object for StopWatch function which is inbuilt in System.Diagnostics
            Stopwatch stopWatch = new Stopwatch();

            Console.Write("Enter any key to start stopwatch\n ");
            Console.ReadKey();

            //started stopwatch
            stopWatch.Start();

            Console.WriteLine("\nEnter any key to stop stopwatch");
            Console.ReadKey();

            //stop stopWatch
            stopWatch.Stop();

            //It will give us elapsed time
            TimeSpan timeSpan = stopWatch.Elapsed;

            Console.WriteLine("\nTime elapsed : {0:hh\\:mm\\:ss}", stopWatch.Elapsed);
        }
    }
}