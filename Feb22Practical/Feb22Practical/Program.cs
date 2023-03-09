using System.Collections;

class Program
{
    static void Main()
    {
        int[] arr = new int[10];
        Array.Resize(ref arr, 15); // output parameter must pass ref keyword. new array will be created and old array will be destroyed

        ArrayList arrayList= new ArrayList(10);
        Console.WriteLine(arrayList.Capacity);
        arrayList.Add(100);
        Console.WriteLine(arrayList.Capacity);
        arrayList.Add(200);
        arrayList.Add(300);
        arrayList.Add(400);
        Console.WriteLine(arrayList.Capacity);
        arrayList.Add(500);
        Console.WriteLine(arrayList.Capacity);

        foreach (object obj in arrayList)
            Console.Write(obj + " ");
        Console.WriteLine();

        arrayList.Insert(3,350);
        foreach (object obj in arrayList)
            Console.Write(obj + " ");
        Console.WriteLine();

        //arrayList.Remove(200);
        arrayList.RemoveAt(1);
        foreach (object obj in arrayList)
            Console.Write(obj + " ");
        Console.WriteLine();

        Console.ReadLine();

    }
}