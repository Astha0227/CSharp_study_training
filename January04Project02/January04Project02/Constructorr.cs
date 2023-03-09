using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January04Project02
{
    internal class Constructorr
    {
        int x;         // initilized by non-static constructor
        static int y; // initilize by static constructor 
        static Constructorr()
        {
            Console.WriteLine("Static Constructor is called."); //implicitly called and 1st method to be called
        }

        public Constructorr()
        {
            Console.WriteLine("Non-Static Constructor is called.");
        }

        static void Main()
        { 
            Console.WriteLine("Main method is called.");
            Constructorr constructorr= new Constructorr(); //non-static constructor is called explicitly 
            Console.WriteLine(y); // we can directly print static constructor value in static class
            Console.WriteLine($"{constructorr.x}"); // we cannot directly print non-static value as it dosen't know who to point
            Console.ReadLine();

        }

    }
}
