using Pieshop2.HR;
using System.Text;

////valuetype

//int a = 89;
//int aCopy = a;
//Console.WriteLine($" Value of a: {a} and value of a copy: {aCopy}");
//aCopy = 09;
//Console.WriteLine($" Value of a: {a} and value of a copy: {aCopy}");

//Console.WriteLine("Creating an employee: ");
//Console.WriteLine("-----------------------\n");

//Employee astha = new Employee("Astha", "Prajapati", "astha@drevol.com", new DateTime(2000, 11, 11), 25, EmployeeType.Manager);

//astha.DisplayEmployeeDetails();

//////converting to json

//string asthaAsJson = astha.ConvertToJson();
//Console.WriteLine(asthaAsJson);


//astha.PerformWork(25);

//int minimumBonus = 100;
////int bonusTax = 0;
//int bonusTax;
//int receievedBonus = astha.CalculateBonus(minimumBonus);
//Console.WriteLine($"The minimum bonus is {minimumBonus} and {astha.firstName} has received a bonus of {receievedBonus}");

//int receievedBonusAndTax = astha.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);
//Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {astha.firstName} has received a bonus of {receievedBonusAndTax}");

//Employee testEmployee = astha;
//testEmployee.firstName = "Gill";
//testEmployee.DisplayEmployeeDetails();
//astha.DisplayEmployeeDetails();

//astha.DisplayEmployeeDetails();

//astha.PerformWork();
//astha.PerformWork();
//astha.PerformWork(5);
//astha.PerformWork();

//double receivedWageAstha = astha.ReceiveWage(true);
//Console.WriteLine($"Wage Paid (message from program): {receivedWageAstha}");

//Console.WriteLine("Creating an employee: ");
//Console.WriteLine("-----------------------\n");

//Employee priya = new("Priya", "Prajapati", "priya2005@gmail.com", new DateTime(2005, 06, 10), 25, EmployeeType.Research);

//priya.DisplayEmployeeDetails();

//priya.PerformWork(4);
//priya.PerformWork();
//priya.PerformWork(5);
//priya.PerformWork();
//priya.PerformWork(5);


//double receivedWagePriya = priya.ReceiveWage(true);
//Console.WriteLine($"Wage Paid (message from program): {receivedWagePriya}");

//Console.WriteLine("Creating an employee: ");
//Console.WriteLine("-----------------------\n");


//priya.DisplayEmployeeDetails();

//priya.PerformWork(4);
//priya.PerformWork();
//priya.PerformWork(5);
//priya.PerformWork();
//priya.PerformWork(5);

//priya.firstName = "Jainil";
//priya.hourlyRate = 10;

//priya.DisplayEmployeeDetails();

//priya.PerformWork(4);
//priya.PerformWork();
//priya.PerformWork(5);
//priya.PerformWork();
//priya.PerformWork();


//double receivedWageJainil = priya.ReceiveWage(true);
//Console.WriteLine($"Wage Paid (message from program): {receivedWageJainil}");

//////string immutability 

//string name = "astha";
//string anotherName = name;
//name += " prajapati";

//Console.WriteLine(name); //name will be concatinate with another string
//Console.WriteLine(anotherName); // anothername will be same as name

//////String builders

//string firstName = "Bethany";
//string lastName = "Smith";

//StringBuilder builder = new StringBuilder();

//builder.Append("Last name: ");
//builder.Append(lastName);
//builder.Append(" First name: ");
//builder.Append(firstName);
//string result = builder.ToString();

//Console.WriteLine(result);

//StringBuilder builder1 = new StringBuilder();

//for (int i = 0; i < 10; i++)
//{
//    builder1.Append(i);
//    builder1.Append(" ");

//}

//string list = builder1.ToString();
//Console.WriteLine(list);



Console.WriteLine("Creating an employee: ");
Console.WriteLine("-----------------------\n");

Employee astha = new Employee("Astha", "Prajapati", "astha@drevol.com", new DateTime(2000, 11, 11), 25, EmployeeType.Manager);

Console.WriteLine("Creating an employee: ");
Console.WriteLine("-----------------------\n");

Employee priya = new("Priya", "Prajapati", "priya2005@gmail.com", new DateTime(2005, 06, 10), 25, EmployeeType.Research);

#region First run Astha 

astha.PerformWork();
astha.PerformWork(5);
astha.PerformWork();
astha.ReceiveWage();
astha.DisplayEmployeeDetails();

#endregion

#region First run Priya

priya.PerformWork(10);
priya.PerformWork();
priya.PerformWork();
priya.ReceiveWage();
priya.DisplayEmployeeDetails();

#endregion

Employee.DisplayTaxRate();













