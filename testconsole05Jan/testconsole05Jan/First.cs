using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testconsole05Jan
{
    internal class First
    {
        static int x = 100;
        int y = 200; 
        static void Main()
        {
            Console.WriteLine(x);

            First first = new First(); // here first is a copy of a class First
            Console.WriteLine(first.y);

            First second = first; // reference of a class
            Console.WriteLine($"Value of reference: {second.y}");
            first.y = 300;
            Console.WriteLine($"Value of instance {first.y} and Value of reference: {second.y}");
            second.y = 400;
            Console.WriteLine($"Value of instance {first.y} and Value of reference: {second.y}");

            Console.ReadLine();
        }
    }
}
