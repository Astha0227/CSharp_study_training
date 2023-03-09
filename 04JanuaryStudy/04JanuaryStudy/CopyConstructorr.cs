using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04JanuaryStudy
{
    internal class CopyConstructorr
    {
        int x;

        public CopyConstructorr(int i)
        {
            x = i;
            Console.WriteLine("Constructor is called.");
        }

        public CopyConstructorr(CopyConstructorr obj)
        {
            x = obj.x;
            Console.WriteLine("Copy Constructor is called.");

        }

        public void Display()
        { 
            Console.WriteLine("Display method is called.");
            Console.WriteLine($"The value of x is: {x}");
        }
    }
}
