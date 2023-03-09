using _04JanuaryStudy;

class Program
{
    int i; bool b; // varables without declaration will be assigned value by compiler 
     
    static void Main(String[] args)
    {
        Console.WriteLine("Hello World! \n");
        Program p = new Program();
        Console.WriteLine("Implicit Constructor: \n");

        Console.WriteLine($"The value of Int i: {p.i}");
        Console.WriteLine($"The value of Bool b: {p.b} \n");

        Console.WriteLine("Explicit Constructor: \n");

        ExplicitConstructorDemo ExpD0 = new ExplicitConstructorDemo();
        ExplicitConstructorDemo ExpD1 = new ExplicitConstructorDemo();
        ExplicitConstructorDemo ExpD2 = new ExplicitConstructorDemo();

        Console.WriteLine("\n");


        Console.WriteLine("Parameterized Constructor: \n");

        ParaCon PCon = new ParaCon(89);
        ParaCon PCon1 = new ParaCon(9);
        ParaCon PCon2 = new ParaCon(84);
        PCon.Display();
        PCon1.Display();
        PCon2.Display();

        Console.WriteLine("\n");


        Console.WriteLine("Copy Constructor: \n");

        CopyConstructorr CCon = new CopyConstructorr(56);
        CCon.Display();
        CopyConstructorr CCon1 = new CopyConstructorr(CCon);
        CCon1.Display();

        



        Console.ReadLine();

    }

}