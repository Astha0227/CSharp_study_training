using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testconsole05Jan //consuming members from the non-child class of same project
{
     class AccessModDemo3 
    {
        static void Main()
        {
            AccessModDemo acc = new AccessModDemo();
           // acc.Test1(); private mathod won't called
            acc.Test2();
           // acc.Test3(); protected won't be called
            acc.Test4();
            acc.Test5();
          
            
            
        }
    }
}
