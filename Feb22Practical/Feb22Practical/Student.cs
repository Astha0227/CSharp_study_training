using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb22Practical
{
    internal class Student
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public float Marks { get; set; }

    }

    class TestStudent
    {
        static void Main()
        {
            Student s1 = new Student { Sid = 101, Name = "Astha", Class = "Vasad", Marks = 250.00f};
            Student s2 = new Student { Sid = 102, Name = "Diya", Class = "Pune", Marks = 200.00f };
            Student s3 = new Student { Sid = 103, Name = "Shiv", Class = "Mumbai", Marks = 350.00f };
            Student s4 = new Student { Sid = 104, Name = "Hitakshi", Class = "Delhi", Marks = 1 50.00f };
        }
    }
}
