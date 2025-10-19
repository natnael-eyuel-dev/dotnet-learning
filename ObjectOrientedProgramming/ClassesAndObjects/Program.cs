// C# OOP - 2.1 Classes and Objects

using System;

namespace ObjectOrientedProgramming.ClassesAndObjects
{
    // Define a class
    public class Person
    {
        // Properties (data)
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor (initializes objects)
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method (behavior)
        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create and use objects
            Person person1 = new Person("Alice", 30);
            Person person2 = new Person("Bob", 25);

            person1.Introduce(); // Output: Hi, I'm Alice and I'm 30 years old.
            person2.Introduce(); // Output: Hi, I'm Bob and I'm 25 years old.
        }
    }
}

/* Expected Output when running "dotnet run"

Hi, I'm Alice and I'm 30 years old.
Hi, I'm Bob and I'm 25 years old.
*/
