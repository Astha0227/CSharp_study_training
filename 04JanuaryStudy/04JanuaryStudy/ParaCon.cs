using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04JanuaryStudy
{
    internal class ParaCon
    {
        int x;  //default value set by compiler is zero. 
        public ParaCon(int i) 
        {
            Console.WriteLine("Parameterized Constructor is called " + i);
            x = i;
        }

        public void Display()
        {
            Console.WriteLine($"Value of X is {x}");
        }
    }
}
