// C# Advanced - 4.2 Exception Handling
using System;

namespace AdvancedCSharp.ExceptionHandling
{
    // Custom exception
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Handling Demo\n");

            // Divide numbers
            DivideNumbers(10, 2);  // Normal
            DivideNumbers(5, 0);   // Divide by zero

            Console.WriteLine();

            // Validate age
            try
            {
                ValidateAge(25);   // Valid
                ValidateAge(-5);   // Invalid
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Invalid age: {ex.Message}");
            }

            Console.WriteLine("\nProgram completed.");
        }

        // Method demonstrating try-catch-finally
        public static void DivideNumbers(int a, int b)
        {
            try
            {
                int result = a / b;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Operation completed.");
            }
        }

        // Method demonstrating custom exceptions
        public static void ValidateAge(int age)
        {
            if (age < 0 || age > 150)
            {
                throw new InvalidAgeException("Age must be between 0 and 150");
            }
            else
            {
                Console.WriteLine($"Age {age} is valid.");
            }
        }
    }
}

/* Expected Output when running 'dotnet run'

Exception Handling Demo

Result: 5
Operation completed.
Cannot divide by zero!
Operation completed.

Age 25 is valid.
Invalid age: Age must be between 0 and 150

Program completed.
*/
