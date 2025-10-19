// C# Fundamentals - 1.1 Variables and Data Types Example

using System;

namespace CSharpFundamentals.VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring and initializing variables
            int age = 25;
            double price = 19.99;
            char grade = 'A';
            string name = "John Doe";
            bool isStudent = true;

            // Using var keyword (implicit typing)
            var city = "New York"; // Compiler infers this is a string
            var count = 10;        // Compiler infers this is an int

            // Changing variable values
            age = 26; // Valid - changing value
            // age = "twenty"; // ERROR - cannot change type

            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}

/* Expected Output when running 'dotnet run'

Name: John Doe, Age: 26
*/