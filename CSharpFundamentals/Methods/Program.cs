// C# Fundamentals - 1.3 Methods (Functions)

using System;

namespace CSharpFundamentals.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling methods
            SayHello();

            int sum = AddNumbers(5, 3);
            Console.WriteLine($"Sum: {sum}");

            PrintMessage("Hello", 3);
            PrintMessage("Single message"); // Using default parameter
        }

        // Method with no parameters and no return value
        static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        // Method with parameters and return value
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        // Method with optional parameters
        static void PrintMessage(string message, int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}

/* Expected Output when running 'dotnet run'

Hello!
Sum: 8
Hello
Hello
Hello
Single message
*/
