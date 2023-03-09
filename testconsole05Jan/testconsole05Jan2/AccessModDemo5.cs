using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testconsole05Jan2 //consuming members from the non-child class of different project
{
    internal class AccessModDemo5
    {
        static void Main()
        {
            testconsole05Jan.AccessModDemo acc5 = new testconsole05Jan.AccessModDemo();
            acc5.Test5();
        }
       

    }
}
