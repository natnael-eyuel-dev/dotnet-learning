// C# Advanced - 4.3 Generics

using System;

namespace AdvancedCSharp.Generics
{
    // Generic class
    public class Box<T>
    {
        private T item;

        public void Pack(T item)
        {
            this.item = item;
        }

        public T Unpack()
        {
            return item;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics Demo\n");

            // ----- Generic Class Example -----
            Box<int> intBox = new Box<int>();
            intBox.Pack(123);
            int intValue = intBox.Unpack();
            Console.WriteLine($"Int box contains: {intValue}");

            Box<string> stringBox = new Box<string>();
            stringBox.Pack("Hello Generics");
            string strValue = stringBox.Unpack();
            Console.WriteLine($"String box contains: {strValue}");

            Console.WriteLine();

            // ----- Generic Method Example -----
            int maxInt = FindMax(10, 20);
            string maxString = FindMax("apple", "banana");

            Console.WriteLine($"Max int: {maxInt}");
            Console.WriteLine($"Max string: {maxString}");
        }

        // Generic method with constraint
        public static T FindMax<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}

/* Expected Output when running 'dotnet run'

Generics Demo

Int box contains: 123
String box contains: Hello Generics

Max int: 20
Max string: banana
*/