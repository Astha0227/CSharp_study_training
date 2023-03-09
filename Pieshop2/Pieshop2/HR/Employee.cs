using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pieshop2.HR
{
    internal class Employee
    {
        private string firstName;
        public string lastName;
        public string email;

        public int numberOfHourWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthDay;

        const int minimalHoursWorkedUnit = 1;

        public EmployeeType employeeType;

        public static double taxRate = 0.15;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }  
        }

        public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0, EmployeeType.StoreManager)
        {

        }


        public Employee(string frist, string last, string em, DateTime bd, double rate, EmployeeType empType)
        {
            firstName = frist;
            lastName = last;
            email = em;
            birthDay = bd;
            hourlyRate = rate;
            employeeType = empType;
        }

        public void PerformWork()
        {
            //numberOfHourWorked++;
            //Console.WriteLine($"{fristName} {lastName} has worked for {numberOfHourWorked} hour(s)!");
            PerformWork(minimalHoursWorkedUnit);

        }

        public void PerformWork(int numberOfHours)
        {
            numberOfHourWorked += numberOfHours;

            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hour(s)!");

        }

        public int CalculateBonus(int bonus)
        {
            if (numberOfHourWorked > 10)
                bonus *= 2;

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;

        }

        /*public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
        {
            if (numberOfHourWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
            return bonus;
        }*/

        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;

            if (numberOfHourWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
            return bonus;

        }

        public double ReceiveWage(bool resetHours = true)
        {
            // wage = numberOfHourWorked * hourlyRate;

            double wageBeforeTax = 0.0;

            if (employeeType == EmployeeType.Manager)
            {
                Console.WriteLine($"An extra was added to the wage since {firstName} is a manager!");
                wageBeforeTax = numberOfHourWorked * hourlyRate * 1.25;
            }
            else
            {
                wageBeforeTax = numberOfHourWorked * hourlyRate;
            }

            double taxAmount = wageBeforeTax * taxRate;

            wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHourWorked} hours of work.");

            if (resetHours)
                numberOfHourWorked = 0;

            return wage;
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\n Frist Name: \t{firstName} \n Last Name: \t{lastName} \n Email: \t{email} \nBirthday: \t{birthDay.ToShortDateString()}\n Tax rate: \t {taxRate}");
        }

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
    }
}
