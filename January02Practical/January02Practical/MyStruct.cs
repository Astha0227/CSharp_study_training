using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January09Practical
{
    struct MyStruct
    {
        int i;

        public MyStruct(int i)
        { 
            this.i = i; 
        }
        public void Dispaly()
        {
            Console.WriteLine("Method in a structure."+i);
        }
        static void Main()
        {
            MyStruct obj; // default constructor using new keyword
            obj.i= 1; //explicit inintilization 
            obj.Dispaly();

            MyStruct obj2 = new MyStruct();
            //obj2.i = 2;
            obj2.Dispaly();

            MyStruct obj3 = new MyStruct(3);
            //obj2.i = 2;
            obj3.Dispaly();
        }
    }
}

