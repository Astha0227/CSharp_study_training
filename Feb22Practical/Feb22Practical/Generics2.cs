using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb22Practical
{
    internal class Generics2<T>
    {

            public void Add<T>(T a, T b)
            {
                dynamic d1 = a;
                dynamic d2 = b;
                Console.WriteLine(d1 + d2);
            }

            public void Sub<T>(T a, T b)
            {
                dynamic d1 = a;
                dynamic d2 = b;
                Console.WriteLine(d1 - d2);
            }
    

            public void Mul<T>(T a, T b)
            {
                dynamic d1 = a;
                dynamic d2 = b;
                Console.WriteLine(d1 * d2);
            }


            public void Div<T>(T a, T b)
            {
                dynamic d1 = a;
                dynamic d2 = b;
                Console.WriteLine(d1 / d2);
            }

    }
    class TestGenerics
    {
        static void Main()
        {
            Generics2<int> obj = new Generics2<int>();
            obj.Add(30, 10);
            obj.Sub(30, 10);
            obj.Mul(30, 10);
            obj.Div(30, 10);

        }

    }

}