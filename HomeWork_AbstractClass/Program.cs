namespace HomeWork_AbstractClass
{
    using System;
    using System.Collections.Generic;
    abstract class Shape:IComparable<Shape>
    {
        private string? name;

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        public Shape(string? name)
        {
            this.name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(Shape other)
        {
            if (other == null)
                return 1;

            // Порівняння фігур за площею
            return Area().CompareTo(other.Area());
        }

    }

    class Circle : Shape
    {
        private double radius;
        public const double PI = 3.1415926535897931;
        public Circle(string? name,double radius): base(name) 
        {
            this.radius = radius;
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        
       public override double Area()
        {
            return PI*radius*radius;
        }

        public override double Perimeter()
        {
           return 2*PI*radius;
        }

    }

    class Square : Shape
    {
        private double side;
        public const double PI = 3.1415926535897931;
        public Square(string? name, double side) : base(name)
        {
            this.side = side;
        }
        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public override double Area()
        {
         return side*side  ;
        }

        public override double Perimeter()
        {
            return 2*(side + side);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter data for Shape {i}:");

                Console.Write("Name: ");
                string? name = Console.ReadLine();

                Console.Write("Side Length: ");
                double side = double.Parse(Console.ReadLine());

                Shape shape = new Square(name, side); // створення об'єкту конкретного класу фігури

                shapes.Add(shape);
            }

            Console.WriteLine("Shapes before sorting:");

            PrintShapes(shapes);

            shapes.Sort(); //Сортування фігур за площею яке реалізоване в  IComparable<Shape>

            Console.WriteLine("Shapes after sorting by area:");

            PrintShapes(shapes);
        }
        public static void PrintShapes(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Name: {shape.Name}");
                Console.WriteLine($"Area: {shape.Area()}");
                Console.WriteLine($"Perimeter: {shape.Perimeter()}");
                Console.WriteLine();
            }
        }
    }
}
