using System.Collections.Generic;
using System.Linq;

class Program
{

    abstract class Shape
    {
        private string name;

        public string Name { get { return name; } }

        protected Shape(string shapeName)
        {
        this.name = shapeName; 
        }
        public abstract double Area();
        public abstract double Perimeter();
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            double ar = Math.Sqrt(radius) * 3.14;
            return ar;
        }

        public override double Perimeter()
        {
            double per = radius * 2 * 3.14;
            return per;
        }

    }

    class Square : Shape
    {
        private int side;

        public Square (string name, int side) : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            double ar = side * side;
            return ar;
        }

        public override double Perimeter()
        {
            double per = side * 4;
            return per;
        }
    }

    public static void Main(string[] args)
    {
        /*Circle circle1 = new Circle("petro", 2.5);
        Square square1 = new Square("vasil", 3);
        double x = circle1.Area();
        Console.WriteLine(x);
        Console.WriteLine(square1.Area());
        */
        List<Shape> shapes = new List<Shape>();

        

        while (shapes.Count() != 2)
        {
            Console.WriteLine("1 for circle, 2 for squre, 3 to show all shapes");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter name");
                    string a = Console.ReadLine();
                    Console.WriteLine("enter radius");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Circle circle = new Circle(a, b);
                    shapes.Add(circle);
                    break;
                case 2:
                    Console.WriteLine("enter name");
                    string c = Console.ReadLine();
                    Console.WriteLine("enter side");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Square square = new Square(c, d);
                    shapes.Add(square);
                    break;
                case 3:
                    break;
            }
        }



        Shape biggest = shapes.MaxBy(x => x.Perimeter());
        Console.WriteLine("the biggest perimeter: "+biggest.Name);

        shapes.Sort((x, y) => y.Area().CompareTo(x.Area()));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Name: " + shape.Name + "\n" + "Area: " + shape.Area() + "\n" + "Perimeter: " + shape.Perimeter() + "\n");

        }

    }
}


   





