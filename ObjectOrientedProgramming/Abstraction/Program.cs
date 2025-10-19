// C# OOP - 2.5 Abstraction

using System;

namespace ObjectOrientedProgramming.Abstraction
{
    // Abstract class (cannot be instantiated)
    public abstract class Vehicle
    {
        public string Brand { get; set; }

        // Abstract method (must be implemented by derived classes)
        public abstract void Start();

        // Regular method
        public void DisplayBrand()
        {
            Console.WriteLine($"Brand: {Brand}");
        }
    }

    // Derived class: Car
    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car engine started with key ignition");
        }
    }

    // Derived class: ElectricCar
    public class ElectricCar : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Electric car started silently");
        }
    }

    // Test Program 
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car { Brand = "Toyota" };
            Vehicle electricCar = new ElectricCar { Brand = "Tesla" };

            car.DisplayBrand();
            car.Start();

            electricCar.DisplayBrand();
            electricCar.Start();
        }
    }
}

/* Expected Output when running 'dotnet run'

Brand: Toyota
Car engine started with key ignition
Brand: Tesla
Electric car started silently
*/
