namespace HomeWork_LINQ
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    abstract class Shape
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"Name: {Name}, Area: {GetArea()}, Perimeter: {GetPerimeter()}";
        }
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    class Square : Shape
    {
        public double SideLength { get; set; }

        public Square(string name, double sideLength) : base(name)
        {
            SideLength = sideLength;
        }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }

        public override double GetPerimeter()
        {
            return 4 * SideLength;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Shape and fill it with 6 different shapes
            List<Shape> shapes = new List<Shape>
        {
            new Circle("Circle 1", 3),
            new Circle("Circle 2", 5),
            new Square("Square 1", 4),
            new Square("Square 2", 6),
            new Circle("Circle 3", 2),
            new Square("Square 3", 3)
        };

            // Find and write shapes with area from range [10, 100] into a file
            var shapesInRange = shapes.Where(shape => shape.GetArea() >= 10 && shape.GetArea() <= 100);
            WriteShapesToFile("shapesInRange.txt", shapesInRange);

            // Find and write shapes which name contains letter 'a' into a file
            var shapesWithNameContainingA = shapes.Where(shape => shape.Name.Contains('a'));
            WriteShapesToFile("shapesWithNameContainingA.txt", shapesWithNameContainingA);

            // Find and remove shapes with perimeter less than 5 from the list
            shapes.RemoveAll(shape => shape.GetPerimeter() < 5);

            // Write the resulting list into the console
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
        static void WriteShapesToFile(string fileName, IEnumerable<Shape> shapes)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var shape in shapes)
                {
                    writer.WriteLine(shape);
                }
            }

            Console.WriteLine($"Shapes written to {fileName}.");
        }
    }
}