// C# OOP - 2.3 Inheritance

using System;

namespace ObjectOrientedProgramming.Inheritance
{
    // Base class (Parent)
    public class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }

    // Derived class (Child)
    public class Dog : Animal
    {
        public string Breed { get; set; }

        // Override parent method
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }

        // Method specific to Dog
        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching the ball!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog { Name = "Buddy", Breed = "Golden Retriever" };

            myDog.Eat();        // Inherited from Animal
            myDog.MakeSound();  // Overridden in Dog
            myDog.Fetch();      // Specific to Dog
        }
    }
}

/* Expected Output when running 'dotnet run'

Buddy is eating.
Woof! Woof!
Buddy is fetching the ball!
*/