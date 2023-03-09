using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Feb22Practical
{
    internal class GenericList
    {
        static void Main()
        {
            List<int> intlist = new List<int>();

            intlist.Add(10); intlist.Add(20); intlist.Add(30);
            intlist.Add(40); intlist.Add(50); intlist.Add(60); // here we cant put double value 

            for(int i = 0; i < intlist.Count; i++)
                Console.WriteLine(intlist[i] + " ");
            Console.WriteLine();

            intlist.Insert(3, 35);
            foreach (int i in intlist)
                Console.Write(i + " ");
            Console.WriteLine();

            intlist.RemoveAt(1);
            foreach (int i in intlist)
                Console.Write(i + " ");
            Console.WriteLine();

            Console.ReadLine();
        }


        
        
        
    }
}
