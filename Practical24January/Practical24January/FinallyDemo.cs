using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical24January
{
    internal class FinallyDemo
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter 1st Number: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd Number: ");
                int y = int.Parse(Console.ReadLine());
                if (y == 1)
                {
                    return;
                }
                int z = x / y;
                Console.WriteLine("The result is: " + z);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block is executed.");

            }
            Console.WriteLine("End of the program.");



        }
    }
}
