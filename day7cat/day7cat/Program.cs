


using day7cat;
using System.ComponentModel.DataAnnotations;

////static class

Song holidday = new Song("Holiday", "Green Day", 200);
Console.WriteLine(holidday.title);
Console.WriteLine(holidday.artist);
Console.WriteLine(holidday.duration);
Console.WriteLine(Song.songCount);
Console.WriteLine("\n");


Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
Console.WriteLine(kashmir.title);
Console.WriteLine(holidday.artist);
Console.WriteLine(kashmir.duration);
Console.WriteLine(kashmir.getSongCount());
Console.WriteLine("\n");


////static method 

UsefulTools.sayHello("Astha");
////UsefulTools tools = new UsefulTools(); // cannot create an instence of static class

Console.WriteLine("\n");


Console.WriteLine("How many IDs do you want to register? ");

int size = int.Parse(Console.ReadLine());

int[] employeeID = new int[size];

Console.WriteLine("\n");

//var testId = employeeID[0];
//Console.WriteLine(testId.ToString());

//Console.WriteLine(testId);

for (int i = 0; i < size; i++)
{
    Console.WriteLine("Enter the employee ID: ");
    int id = int.Parse(Console.ReadLine());
    employeeID[i] = id;
}

Console.WriteLine("\n");

for (int i = 0; i < employeeID.Length; i++)
{
    Console.WriteLine($"ID {i + 1} : \t{employeeID[i]}");
}

Array.Sort(employeeID); ///array sorting 

Console.WriteLine("\n");
Console.WriteLine("Sorted Array");


for (int i = 0; i < employeeID.Length; i++)
{
    Console.WriteLine($"ID {i + 1} : \t{employeeID[i]}");
}

Console.WriteLine("\n");

int[] employeeIDcopy = new int[size];

employeeID.CopyTo(employeeIDcopy, 0);

Console.WriteLine("Copy of array:");

for (int i = 0; i < employeeIDcopy.Length; i++)
{
    Console.WriteLine($"ID {i + 1} : \t{employeeIDcopy[i]}");
}

Console.WriteLine("\n");

Array.Reverse(employeeID);

Console.WriteLine("After reversing the Array: ");

for (int i = 0; i < employeeID.Length; i++)
{
    Console.WriteLine($"ID {i + 1} : \t{employeeID[i]}");
}

List<int> employeeIDs = new List<int>();

employeeIDs.Add(33);
employeeIDs.Add(34);
employeeIDs.Add(44);
employeeIDs.Add(87);
employeeIDs.Add(55);

////employeeIDs.Add("rest"); //copiler won't take this value 

if(employeeIDs.Contains(55))
{
    Console.WriteLine("55 found!");
}

int currentAmountOfEmployee = employeeIDs.Count;

var employeeIDarray = employeeIDs.ToArray();

employeeIDs.Clear();

Console.WriteLine("How many IDs do you want to register? ");

int size = int.Parse(Console.ReadLine());


Console.WriteLine("\n");

for (int i = 0; i < size; i++)
{
    Console.WriteLine("Enter the employee ID: ");
    int id = int.Parse(Console.ReadLine());
    employeeIDs.Add(id);
}






























































































































