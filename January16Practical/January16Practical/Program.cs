namespace January16Practical
{ 
    class Program
    {
        public void AddNums(int num, int num2)
        {
            Console.WriteLine(num + num2);
        }

        public static string SayHello(string name)
        {
            return "Hello " + name; 
        }
        static void Main()
        { 
            Program program= new Program();
            program.AddNums(10, 20);

            string str = Program.SayHello("Helly");
            Console.WriteLine(str);
        }
    }
}