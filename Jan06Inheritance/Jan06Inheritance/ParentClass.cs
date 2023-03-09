using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan06Inheritance
{
    internal class ParentClass
    {
        public virtual void Test1()
        {
            Console.WriteLine("Method Test1 from parent class with virtual keyword.");
        }

        public void Test2()
        {
            Console.WriteLine("Method Test2 from parent class without virtual keyword.");
        }
    }

    class ChildClass  : ParentClass
    {
        public override void Test1()
        {
            Console.WriteLine("Method Test1 from child class with override keyword.");
        }

        public new void  Test2() 
        {
            Console.WriteLine("Method Test2 from child class without virtual keyword.");
        }

        public void ParentTest1()
        { 
            base.Test1();
        }

        public void ParentTest2()
        {
            base.Test2();
        }
        static void Main()
        { 
            ChildClass childClass= new ChildClass();
            //childClass.Test1();
            //childClass.Test2();
            //childClass.ParentTest1();
            //childClass.ParentTest2();

            ParentClass parentClass = childClass; //parentClass is a refrence of parent class created by using child's instance 
            parentClass.Test1(); //invokes child class's method
            parentClass.Test2(); //invokes parent class's method

            //ParentClass parentsClass = new ParentClass();
            //parentsClass.Test1();
            //parentsClass.Test2();

        }
    }
}
