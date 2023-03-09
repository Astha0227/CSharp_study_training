using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testconsole05Jan //consuming members from the child class of same project
{       
    internal class AccessModDemo2 : AccessModDemo 
    {
        static void Main()
        {
            AccessModDemo2 acc = new AccessModDemo2();
            //acc.Test1(); private method
            acc.Test2();
            acc.Test3();    
            acc.Test4();
            acc.Test5();
            Console.ReadLine();
        }
        


    }
}
