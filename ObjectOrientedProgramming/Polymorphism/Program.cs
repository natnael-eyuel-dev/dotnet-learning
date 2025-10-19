// C# OOP - 2.4 Polymorphism
using System;

namespace ObjectOrientedProgramming.Polymorphism
{
    // ----- Compile-time Polymorphism (Method Overloading) -----
    public class Calculator
    {
        // Same method name, different parameter types or counts
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    // ----- Runtime Polymorphism (Method Overriding) -----
    public class Shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    // ----- Test Program -----
    class Program
    {
        static void Main(string[] args)
        {
            // Compile-time Polymorphism (Overloading)
            Calculator calc = new Calculator();
            Console.WriteLine("Calculator Add method results:");
            Console.WriteLine(calc.Add(5, 3));           // Uses first method
            Console.WriteLine(calc.Add(5.5, 3.2));       // Uses second method
            Console.WriteLine(calc.Add(1, 2, 3));        // Uses third method

            Console.WriteLine();

            // Runtime Polymorphism (Overriding)
            Shape shape1 = new Circle { Radius = 5 };
            Shape shape2 = new Rectangle { Width = 4, Height = 6 };

            Console.WriteLine("Shape area calculations (runtime polymorphism):");
            Console.WriteLine($"Circle area: {shape1.CalculateArea()}");
            Console.WriteLine($"Rectangle area: {shape2.CalculateArea()}");
        }
    }
}

/* Expected Output when running 'dotnet run'

Calculator Add method results:
8
8.7
6

Shape area calculations (runtime polymorphism):
Circle area: 78.53981633974483
Rectangle area: 24
*/