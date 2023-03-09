using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProgramJan05
{
    internal class Class2 : Class1
    {
        public Class2(int a) : base(10)
        {
            Console.WriteLine("Class2 constructor is called." + a);
        } 
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main()
        {
            Class1 class1= new Class1(56);
            class1.Test1();
            Class2 class2= new Class2(45);  
            class2.Test2();

            class2.Test3();

            Class1 c1; //c1 is a variable of Class1
            Class2 c2 = new Class2(12); //c2 is an instance of class2
            c1 = c2; //c1 is a reference of a parent class created by usind child class instance
            c1.Test1();
            c1.Test2();

            Object obj = new Object();
            Console.WriteLine(obj.GetType());
            Console.WriteLine(class1.GetType());
            Console.WriteLine(class2.GetType());

            Console.ReadLine();
        }

      

    }
}
