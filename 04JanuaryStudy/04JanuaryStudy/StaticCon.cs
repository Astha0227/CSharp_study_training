using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04JanuaryStudy
{
    class StaticCon
    {
        static StaticCon()
        {
            Console.WriteLine("Static constructor is executed.");
        }
        static void Main() 
        {
            Console.WriteLine("Main method is executed.");
        }
    }

}