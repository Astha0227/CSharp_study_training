using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January09Practical
{
    interface Interface1 
    {
        void Test();
        void Show();
    
    }

    interface Interface2
    {
        void Test();
        void Show();

    }
    class MultipleInheritanceTest : Interface1, Interface2
    {
        public void Test()
        {
            Console.WriteLine("Multiple Inheritance test in interface is succeed.");

        }

         void Interface1.Show()
        {
            Console.WriteLine("Declare in Interface1 and implemented in class.");

        }

         void Interface2.Show()
        {
            Console.WriteLine("Declare in Interface2 and implemented in class.");

        }
        static void Main()
        {
            MultipleInheritanceTest obj = new MultipleInheritanceTest();    
            obj.Test();

            Interface1 i1 = obj; // explicit implimentation while using public void method() it will be implicit implimentation 
            i1.Show();
            Interface2 i2 = obj;
            i2.Show();
            Console.ReadLine();

        }

    }
}
