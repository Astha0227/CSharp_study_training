using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical23January
{
    internal class TestExtMethods
    {
        static void Main()
        { 
            Program program = new Program();
            program.Test1();
            program.Test2();
            program.Test3(10);

            int i = 5;
            long result  = i.Factorial();
            Console.WriteLine("Factorial of {0} is {1}." ,i,result);

            String str = "Hi, ThIs AsTHa, HeRe";
            str = str.ToUpper();
            Console.WriteLine(str);
            str = str.ToProper();
            Console.WriteLine(str);

                
        }
    }
}
