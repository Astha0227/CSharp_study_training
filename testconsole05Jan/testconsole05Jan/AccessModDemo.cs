using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testconsole05Jan //consuming memebers from the same class
{
    public class AccessModDemo
    {
        private void Test1()
        {
            Console.WriteLine("Private Method.");
        }
        internal void Test2()
        {
            Console.WriteLine("Internal Method.");
        }
        protected void Test3()
        {
            Console.WriteLine("Protected Method.");
        }
        protected internal void Test4()
        {
            Console.WriteLine("Protected internal Method.");
        }
        public void Test5()
        {
            Console.WriteLine("Public Method.");
        }

        static void Main()
        { 
            AccessModDemo acc = new AccessModDemo();
            acc.Test1();
            acc.Test2();
            acc.Test3();
            acc.Test4();
            acc.Test5();
            Console.ReadLine();
        }
    }
}
