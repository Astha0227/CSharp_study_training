using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb22Practical
{
    internal class Generics1
    {
        //public bool Compare(int a, int b) // int
        //{ 
        //   if (a == b)
        //        return true;
        //   return false;
        //}

        //public bool Compare(float a, float b) // float
        //{
        //    if (a == b)
        //        return true;
        //    return false;
        //}

        //public bool Compare(object a, object b) //object 
        //{
        //    if (a.Equals(b))
        //        return true;
        //    return false;
        //}

        public bool Compare<T>(T a, T b) //object 
        {
            if (a.Equals(b))
                return true;
            return false;
        }


        static void Main()
        {
            Generics1 obj = new Generics1();

            //bool result = obj.Compare(true, true);
            //Console.WriteLine($"Bool value: {result} ");

            //bool result1 = obj.Compare(12, 120.22f);
            //Console.WriteLine("Int value: " + result1)

            bool result1 = obj.Compare<float>(12.45f, 120.22f); //float
            Console.WriteLine("Int value: " + result1);

            bool result3 = obj.Compare<int>(10  , 10); //int
            Console.WriteLine("Int value: " + result3);

            //bool result2 = obj.Compare("Hello","Hello");
            //Console.WriteLine("String value: " + result2);


            Console.ReadLine();

        }
    }
}
