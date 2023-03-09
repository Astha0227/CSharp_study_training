using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace February10Practical
{
    internal class ThreadPriorities
    {
        static long Count1, Count2;

        public static void IncrementCount1()
        {
            while (true) //indefinite loop
                Count1 += 1;
        }

        public static void IncrementCount2()
        {
            while (true) //indefinite loop
                Count2 += 1;
        }

        static void Main()
        {
            Thread t1 = new Thread(IncrementCount1); // threads are created
            Thread t2 = new Thread(IncrementCount2);

            t1.Priority= ThreadPriority.Lowest; // less CPU recources are used
            t2.Priority= ThreadPriority.Highest; // more CPU recources are used 

            t1.Start();
            t2.Start();

            Console.WriteLine("Main thread going to sleep.");
            Thread.Sleep(1000); // main method is going to sleep for 10 sec.
            Console.WriteLine("Main thread woke up.");

            t1.Abort(); // this does not worked well hence failed 
            t2.Abort();

            t1.Join();
            t2.Join();

            Console.WriteLine($"Count1: {Count1}");
            Console.WriteLine($"Count2: {Count2}");

            Console.ReadLine();
        }
    }
}
