using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January13Practical
{
    internal class TestEmployee
    {
        static void Main()
        {

            Employee Emp = new Employee(1001, "Astha", "Manager", 20000.00, "Sales", "Mumbai");
            Console.WriteLine("Eno: " + Emp[0]);
            Console.WriteLine("Ename: " + Emp[1]);
            Console.WriteLine("Job: " + Emp[2]);
            Console.WriteLine("Salary: " + Emp[3]);
            Console.WriteLine("Dname: " + Emp[4]);
            Console.WriteLine("Location: " + Emp[5]);

            Emp[0] = 1002;
            Emp[2] = "Sr.Manager";
            Emp[3] = 40000.00;

            Console.WriteLine();
            Console.WriteLine("Eno: " + Emp[0]);
            Console.WriteLine("Ename: " + Emp[1]);
            Console.WriteLine("Job: " + Emp[2]);
            Console.WriteLine("Salary: " + Emp[3]);
            Console.WriteLine("Dname: " + Emp[4]);
            Console.WriteLine("Location: " + Emp[5]);

            Console.ReadLine();

        }



    }
}
