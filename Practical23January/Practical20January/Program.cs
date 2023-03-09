namespace Practical23January
{
    class Program
    { 
        public void Test1()
        {
            Console.WriteLine("Method 1");
        }

        public void Test2()
        {
            Console.WriteLine("Method 2");
        }

        static void Main(string[] args) 
        {
            Program program = new Program();
            program.Test1();
            program.Test2();

        }
    }
}