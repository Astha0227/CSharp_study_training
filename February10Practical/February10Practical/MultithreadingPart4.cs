using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February10Practical
{
    internal class MultithreadingPart4
    {
        static void Test1()
        {
            Console.WriteLine("Thread1 is Started");
            for (int i = 1; i <= 25; i++)
            { 
                Console.WriteLine("Test1: " + i);
            }
            Console.WriteLine("Thread1 is Exiting");

        }

        static void Test2()
        {
            Console.WriteLine("Thread2 is Started");

            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine("Test2: " + i);
            }
            Console.WriteLine("Thread2 is Exiting");
        }

        static void Test3()
        {
            Console.WriteLine("Thread3 is Started");

            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine("Test3: " + i);
            }
            Console.WriteLine("Thread3 is Exiting");
        }

        static void Main()
        {
            Console.WriteLine("Main Thread Started");
            Thread t1= new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();t2.Start();t3.Start();
            t1.Join(3000);t2.Join();t3.Join();
            Console.WriteLine("Main Thread Exiting");
            Console.ReadLine();

        }
    }
}
