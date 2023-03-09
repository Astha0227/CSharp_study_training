using System.Security.Cryptography.X509Certificates;
using testconsole05Jan;

namespace testconsole05Jan2
{
    class AccessModDemo4 : testconsole05Jan.AccessModDemo  //consuming members from the child class of different project
    {
          static void Main()
            {
            Console.WriteLine("Access Modifier Demo4: consuming members from the child class of different project");
                AccessModDemo4 acc2 = new AccessModDemo4();
                // acc.Test1(); private won't be access only of Parent's access
                //  acc.Test2(); internal access only for their project
                acc2.Test3(); //protected
                acc2.Test4();//protected internal
                acc2.Test5();//public
            }
        
    }
}