using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January16Practical
{ 

    public delegate void AddDelegate(int x,int y);
    public delegate string SayDelegate(string str);

    internal class ProgramDelegate
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
            Program program = new Program();

            AddDelegate ad = new AddDelegate(program.AddNums);
            ad(100, 52);
            ad.Invoke(56, 23);

            SayDelegate sd = new SayDelegate(Program.SayHello);
            string str = sd("Himali");
            string str1 = sd.Invoke("Aarati");

            Console.WriteLine(str);
            Console.WriteLine(str1);

        }
    }
}
