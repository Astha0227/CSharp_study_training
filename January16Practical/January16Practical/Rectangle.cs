using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January16Practical
{
    public delegate void RectDelegate(double Width, double Height);
    internal class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area of rectangle: " + Width * Height);
        }

        public void GetPerimeter(double Width, double Height)
        { 
            Console.WriteLine("Perimeter of rectangle: " + (Width + Height) * 2 );
        }

        static void Main()
        {
            Rectangle rect = new Rectangle();

            //rect.GetArea(12.35, 8.32);
            //rect.GetPerimeter(12.35, 8.32);

            //RectDelegate obj = new RectDelegate(rect.GetArea);
            
            RectDelegate obj = rect.GetArea;
            obj += rect.GetPerimeter;

            obj.Invoke(12.35, 8.32);

            Console.WriteLine();

            obj.Invoke(6.79, 5.20);
           
        }

    }
}
