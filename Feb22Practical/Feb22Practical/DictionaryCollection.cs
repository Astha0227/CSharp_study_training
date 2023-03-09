using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb22Practical
{
    internal class DictionaryCollection
    {
        static void Main()
        { 
            Dictionary<string,object> dt = new Dictionary<string,object>();
            dt.Add("Eid", 1010);
            dt.Add("Ename", "Scott");
            dt.Add("Job", "Manager");
            dt.Add("Salary", 25000.00);
            dt.Add("Mgrid", 1002);
            dt.Add("Phone", "1269850036");
            dt.Add("Email", "Scott@drevol.com");
            dt.Add("Dname", "Sales");
            dt.Add("Location", "Mumbai");
            dt.Add("Did", 30);

            foreach (string key in dt.Keys)
            {
                Console.WriteLine(key + ":" + dt[key]);
            }

            Console.ReadLine();


        }
    }
}
