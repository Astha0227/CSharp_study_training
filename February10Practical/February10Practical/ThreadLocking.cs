using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February10Practical
{
    internal class ThreadLocking
    {
        public void Display()
        {
            lock (this)
            {
                Console.Write("[C Sharp is an ");
                Thread.Sleep(5000);
                Console.WriteLine("Object Oriented Language.]");
            }
        }

        static void Main()
        { 
            ThreadLocking obj = new ThreadLocking();

            Thread t1 = new Thread(obj.Display);
            Thread t2 = new Thread(obj.Display);
            Thread t3 = new Thread(obj.Display);
            t1.Start();
            t2.Start();
            t3.Start();

            //obj.Display();
            //obj.Display();
            //obj.Display();
            Console.ReadLine();

        }
    }
}
