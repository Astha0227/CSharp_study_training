using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical24January
{
    internal class TryCatchDemo
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter 1st Number: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd Number: ");
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("The result is: " + z);
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }

            catch (FormatException ex2)
            {
                Console.WriteLine("Input must be numaric value.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.WriteLine("End of the program.");




        }
    }
}
