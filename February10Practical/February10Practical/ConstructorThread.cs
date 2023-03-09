using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February10Practical
{
    internal class ConstructorThread
    {
        //static void Test()
        //{
        //    for (int i = 1; i <= 100; i++)
        //        Console.WriteLine("Test: " + i);
        //    Console.WriteLine("Thread is exiting.");

        //}

        static void Test(object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 1; i <= num; i++)
                Console.WriteLine("Test: " + i);
            Console.WriteLine("Thread is exiting.");

        }

        static void Main()
        {
            //ThreadStart obj = new ThreadStart(Test);
            //Thread Thrd = new Thread(obj);

            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test);
            Thread Thrd = new Thread(obj);
            Thrd.Start(50);
            Console.ReadLine();


        }
    }
}