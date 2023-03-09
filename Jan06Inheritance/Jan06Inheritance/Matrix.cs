using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan06Inheritance
{
    internal class Matrix
    {
        int a, b, c, d;
        public Matrix(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c; 
            this.d = d;
        }

        public override string ToString()
        {
            return a + " " + b + "\n" + c + " " + d + "\n";
        }
        public static Matrix operator+(Matrix obj1, Matrix obj2) 
        {
            Matrix obj = new Matrix(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
            return obj;
        }

        public static Matrix operator -(Matrix obj1, Matrix obj2)
        {
            Matrix obj = new Matrix(obj1.a - obj2.a, obj1.b - obj2.b, obj1.c - obj2.c, obj1.d - obj2.d);
            return obj;
        }
    }

    class TestMatrix
    {
        static void Main()
        {
            Matrix matrix = new Matrix(20,18,16,14);
            Matrix matrix1 = new Matrix(44, 80, 41, 90);
            Matrix matrix2 = matrix + matrix1;
            Matrix matrix3 = matrix - matrix1;

            Console.WriteLine(matrix);
            Console.WriteLine(matrix1);
            Console.WriteLine(matrix2);
            Console.WriteLine(matrix3);

            


        }
    }
}
