


using Pieshop;

int amount = 1234;
int month = 12;
int bonus = 1000;


int yearlyWage = Utilities.CalculteYearlyWage(amount,month);
int yearlyWageBonus = Utilities.CalculteYearlyWage(amount, month, bonus);


Console.WriteLine($"Yearly Wage: {yearlyWage}");
Console.WriteLine($"Yearly Wage with bonus: {yearlyWageBonus}");

Utilities.OptionalParamemters();
Utilities.NamedArguments();
Utilities.ParsingStrings();

Console.ReadLine();





