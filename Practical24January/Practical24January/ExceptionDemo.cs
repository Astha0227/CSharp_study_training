using System;
class ExceptionDemo
{
    static void Main()
    {
        Console.Write("Enter 1st Number: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter 2nd Number: ");
        int y = int.Parse(Console.ReadLine());
        int z = x / y;
        Console.WriteLine("The result is: " + z);
        Console.WriteLine("End of the program.");


    }
}