using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan06Inheritance
{
    internal class LoadParent
    {

        public void Show()
        {
            Console.WriteLine("Parent's Show method for overloading called.");
        }
        public virtual void Test()
        {
            Console.WriteLine("Parent's Test method is called for method overriding.");
        }
    }
    class LoadChild : LoadParent
    {
        public void Show(int i)
        {
            Console.WriteLine("Child's Show method for overloading called."+i);
        }

        public override void Test()
        {
            Console.WriteLine("Child's Test method is called for method overriding.");
        }
        static void Main()
        { 
            LoadChild child= new LoadChild();   
            child.Show();
            child.Test();
            child.Show(33);
            


            Console.ReadLine();
        }
    }
}
