using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb22Practical
{
    internal class Customer
    {
        public int Custid { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public double Balance { get; set; }
    }

    class TestCustomer
    {
        static void Main()
        { 
            List<Customer> CustomerList = new List<Customer>();

            Customer c1 = new Customer { Custid = 101, Name = "Astha", City = "Vasad", Balance = 25000.00 };
            Customer c2 = new Customer { Custid = 102, Name = "Diya", City = "Pune", Balance = 20000.00 };
            Customer c3 = new Customer { Custid = 103, Name = "Shiv", City = "Mumbai", Balance = 35000.00 };
            Customer c4 = new Customer { Custid = 104, Name = "Hitakshi", City = "Delhi", Balance = 10000.00 };

            CustomerList.Add(c1);
            CustomerList.Add(c2);
            CustomerList.Add(c3);
            CustomerList.Add(c4);

            foreach (Customer obj in CustomerList)
            { 
                Console.WriteLine($"Custid: {obj.Custid} Name: {obj.Name} City: {obj.City} Balance: {obj.Balance}" );
            }

            Console.ReadLine();
        }
    }
}
