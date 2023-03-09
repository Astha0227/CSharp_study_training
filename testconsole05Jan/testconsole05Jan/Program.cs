class program
{
    int x=10; //non-static
    static int y=100; //static
    const float pi=3.14f;
    readonly Boolean flag;

    public program(bool flag, int x)
    { 
        this.flag=flag;
        this.x=x;
    }

    static void Main()
    {
        int z; // static because defined under static method
        Console.WriteLine(y);
        program p = new program(true,54);
        Console.WriteLine($"{p.flag} and {p.x} ");
       // p.flag = flase;   can't change readonly variable's value

        program p2= new program(false,43);
        p2.x = 54;
        Console.WriteLine($"{p2.flag} and {p2.x}");
        
    }
}