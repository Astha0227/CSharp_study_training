namespace AbstractImplimentation
{
    public abstract class Figure
    {
        public double Width, Height, Redius;
        public const float Pi = 3.14f;
        public abstract double GetArea();
    }

    public class Rectange : Figure
    {
        public Rectange(double Width, double Height)
        { 
            this.Width = Width;
            this.Height = Height;
        }
        public override double GetArea() 
        { 
            return Width * Height;
        }
    }

    public class Circle : Figure
    {
        public Circle(double Radius)
        { 
            this.Redius = Radius;
        }
        public override double GetArea()
        {
            return Pi * Redius * Redius;
        }
    }

    public class Cone : Figure
    {
        public Cone(double Radius, double Height)
        {
            this.Redius = Radius;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Pi * Redius * (Math.Sqrt(Height * Height + Redius * Redius));
        }

        class TestFigures
        {
            static void Main()
            {
                Rectange r = new Rectange(12.89,21.08);
                Circle c = new Circle(56.01);
                Cone co = new Cone(54.20,54.01);

                Console.WriteLine("Area of Rectangle: "+r.GetArea());
                Console.WriteLine("Area of Circle: " + c.GetArea());
                Console.WriteLine("Area of Cone: " + co.GetArea());


            }
        }
    }
}