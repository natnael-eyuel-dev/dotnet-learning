// C# Fundamentals - 1.2 Control Structures

using System;

namespace CSharpFundamentals.ControlStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- Conditional Statements -----

            // If-else statement
            int score = 85;

            if (score >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else
            {
                Console.WriteLine("Grade: C or below");
            }

            // Switch statement
            string day = "Monday";

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                    Console.WriteLine("Beginning of the week");
                    break;
                case "Friday":
                    Console.WriteLine("Almost weekend!");
                    break;
                default:
                    Console.WriteLine("Regular day");
                    break;
            }

            // ----- Loops -----

            // For loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteration: {i}");
            }

            // While loop
            int counter = 0;
            while (counter < 3)
            {
                Console.WriteLine($"Counter: {counter}");
                counter++;
            }

            // Foreach loop
            string[] fruits = { "Apple", "Banana", "Orange" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}

/* Expected Output when running 'dotnet run'
Grade: B
Beginning of the week
Iteration: 0
Iteration: 1
Iteration: 2
Iteration: 3
Iteration: 4
Counter: 0
Counter: 1
Counter: 2
Apple
Banana
Orange
*/
