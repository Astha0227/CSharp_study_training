using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January10Practical
{
    internal class TestCustomer
    {
        static void Main()
        {
            Customer cobj = new Customer(101,true,"John",500000.00,Cities.Bengaluru,"Karnataka");
            Console.WriteLine("Customer ID: " + cobj.CustId );
            // cobj.CustId = 103; //cannot assign the value because it is read only

            if (cobj.Status == true) 
                Console.WriteLine("CUstomer's current status is: Active");
            else 
                Console.WriteLine("CUstomer's current status is: In-Active");


            //Console.WriteLine("Customer's current status: " + cobj.Status);
            Console.WriteLine("Customer's name: " + cobj.CName);

            cobj.CName += "  Smith";
            Console.WriteLine("Customer's Modifided name: " + cobj.CName);

            Console.WriteLine("Customer's current balance: " + cobj.Balance);

            cobj.Balance -= 3000;
            Console.WriteLine("Customer's current balance: " + cobj.Balance);

            cobj.Balance = cobj.Balance - 914500;
            Console.WriteLine("Transection is not possiblle, it exceeds the current balance, current balance is: " + cobj.Balance);

            Console.BackgroundColor= ConsoleColor.DarkCyan;

            Console.WriteLine("Customer's City: " + cobj.City);

            cobj.City = Cities.Chennai;

            Console.WriteLine("Customer's Modifided name of the City: " + cobj.City);

            Console.WriteLine("State Name of the customer: " + cobj.State);

           // cobj.State = "Telangana";
            Console.WriteLine("Modified state name of the customer: " + cobj.State);

            Console.WriteLine("Country name of the customer: " + cobj.Country);


            Console.ReadLine();

        }
    }
}
