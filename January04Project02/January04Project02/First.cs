using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January04Project02 // why we need to define constructor?
{
    internal class First
    {
        public int x = 100;
    }

    class Second
    {
        public int y;

        public Second(int y)
        { 
            this.y = y;
        }
    }

    class TestClasses
    {
        static void Main()
        {
            First first = new First();
            First first1 = new First();
            First first2 = new First();
            Console.WriteLine($"{first.x} {first1.x} {first2.x}");

            Second second = new Second(89);
            Second second1 = new Second(45);
            Second second2 = new Second(10);
            Console.WriteLine($"{second.y} {second1.y} {second2.y}");



        }
    }
}
