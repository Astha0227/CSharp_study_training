using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb22Practical
{
    internal class HashCollection
    {
        static void Main()
        { 
            Hashtable hashtable= new Hashtable();
            hashtable.Add("Eid",1010);
            hashtable.Add("Ename","Scott");
            hashtable.Add("Job", "Manager" );
            hashtable.Add("Salary", 25000.00);
            hashtable.Add("Mgrid", 1002 );
            hashtable.Add("Phone", "1269850036" );
            hashtable.Add("Email", "Scott@drevol.com" );
            hashtable.Add("Dname", "Sales");
            hashtable.Add("Location", "Mumbai" );
            hashtable.Add("Did", 30 );

            // Console.WriteLine(hashtable["Email"]);

           // Console.WriteLine("Hello".GetHashCode());

            foreach (object key in hashtable.Keys)
            {
                Console.WriteLine(key + ":" + hashtable[key]);
            }
                
            Console.ReadLine();



        }
    }
}
