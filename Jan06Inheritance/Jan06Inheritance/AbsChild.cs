using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan06Inheritance
{
    internal class AbsChild : AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main()
        { 
            AbsChild absChild= new AbsChild();
            absChild.Add(150, 45);
            absChild.Sub(150, 45);
            absChild.Mul(150, 12);
            absChild.Div(150, 10);
            Console.WriteLine("\n");

            //here parents class refrence is created by using child class instance

            AbsParent absParent = absChild;
            Console.WriteLine("parents class refrence is created by using child class instance:");

            absParent.Add(56,12);
            absParent.Sub(56, 12);
            absParent.Mul(56, 12);
            absParent.Div(56, 12);




        }
    }
}
