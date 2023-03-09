using System.Runtime;

namespace Jan06MethodOverring
{
    class Program
    {
        public void Test()
        {
            Console.WriteLine("1st method called.");
        }

        public void Test(int i)
        {
            Console.WriteLine("2nd method called. "+ i);
        }

        public void Test(string s)
        {
            Console.WriteLine("3rd method called. "+ s);
        }

        public void Test(int i, string s)
        {
            Console.WriteLine("4th method called."+ i +"," + s);
        }

        public void Test(string s, int i)
        {
            Console.WriteLine("5th method called."+ s +"," + i);
        }

        static void Main(string[] args) 
        {
            Program program = new Program();
            program.Test();
            program.Test(10);
            program.Test("Astha");
            program.Test(89,"Prajapati");
            program.Test("says",21);




        }
    }

}