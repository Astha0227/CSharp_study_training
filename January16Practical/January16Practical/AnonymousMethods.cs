using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace January16Practical
{
    public delegate string GreetingsDelegate(string name);
    internal class AnonymousMethods
    {
        //public static string Greetings(string name)
        //{ 
        //    return "Hello " + name + " a very Good Morning.";
        //}

        static void Main()
        {
            //GreetingsDelegate obj = new GreetingsDelegate(Greetings);

           

            GreetingsDelegate obj = delegate (string name)   //anonymous method 
            {
                return "Hello " + name + " a very Good Morning.";
            };

            string str = obj.Invoke("Astha");
            Console.WriteLine(str);


        }
    }
}
