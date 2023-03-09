using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pieshop
{
    internal class Utilities
    {
        public static void ParsingStrings()
        {
            Console.WriteLine("Enter the Wage: ");
            string wage = Console.ReadLine();

            //int wageValue = int.Parse(wage); 

            int wageValue;
            if (int.TryParse(wage, out wageValue))
                Console.WriteLine("Parsing success: " + wageValue);
            else
                Console.WriteLine("Parsing failed");

            string hireDateString = "20/12/2022";
            DateTime hireDate = DateTime.Parse(hireDateString);
            Console.WriteLine("Parsed date: " + hireDate);
        }
        public static void NamedArguments()
        {
            int amount = 1234;
            int months = 12;
            int bonus = 500;

            int yearlyWageForEmployee = CalculateYearlyWageWithNamed(bonus: bonus, monthlyWade: amount, numberOfMonthsWorked: months);

            Console.WriteLine($"Yearly wage for employee (me): {yearlyWageForEmployee}");

        }

        public static int CalculateYearlyWageWithNamed(int monthlyWade, int numberOfMonthsWorked,int bonus)
        {
            Console.WriteLine($"The yearly wage is: {monthlyWade * numberOfMonthsWorked + bonus} ");

            return monthlyWade * numberOfMonthsWorked + bonus;
        }
        public static void OptionalParamemters()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;

            int yearlyWageForEmployee1 = CalculteYearlyWageWithOptional(monthlyWage1, months1);

            Console.WriteLine($"Yearly wage for employee1 (me): {yearlyWageForEmployee1}");

        }
        public static int CalculteYearlyWageWithOptional(int monthlyWage, int numberOfMonthsWorked, int bonus = 0)
        {

            Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked + bonus}");

            return monthlyWage * numberOfMonthsWorked + bonus;
        }
        public static int CalculteYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            
            //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");

            if (numberOfMonthsWorked == 12)
                return monthlyWage * (numberOfMonthsWorked + 1);

            return monthlyWage * numberOfMonthsWorked;
        }

        public static int CalculteYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            
            Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked + bonus}");

            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        
    }
}
