# .NET Learning Repository

This repository contains my personal notes and projects while learning **C# and .NET**. It covers foundational concepts, object-oriented programming, collections, LINQ, and advanced topics such as asynchronous programming, exception handling, and generics. Each section includes practical examples and runnable code to reinforce learning.

---

## Table of Contents

1. [C# Fundamentals](./CSharpFundamentals/)  
   - 1.1 [Variables and Data Types](./CSharpFundamentals/VariablesAndDataTypes/)
   - 1.2 [Control Structures](./CSharpFundamentals/ControlStructures/)
   - 1.3 [Methods](./CSharpFundamentals/Methods/) 

2. [Object-Oriented Programming (OOP)](./ObjectOrientedProgramming/)  
   - 2.1 [Classes and Objects](./ObjectOrientedProgramming/ClassesAndObjects/) 
   - 2.2 [Encapsulation](./ObjectOrientedProgramming/Encapsulation/)  
   - 2.3 [Inheritance](./ObjectOrientedProgramming/Inheritance/)  
   - 2.4 [Polymorphism](./ObjectOrientedProgramming/Polymorphism/)  
   - 2.5 [Abstraction](./ObjectOrientedProgramming/Abstraction/)  

3. [Collections and LINQ](./CollectionsAndLINQ/)  
   - 3.1 [Collections](./CollectionsAndLINQ/Collections/)
   - 3.2 [LINQ](./CollectionsAndLINQ/LINQ/) 

4. [Advanced C# Concepts](./AdvancedCSharp/)  
   - 4.1 [Asynchronous Programming](./AdvancedCSharp/AsyncProgramming/)
   - 4.2 [Exception Handling](./AdvancedCSharp/ExceptionHandling/) 
   - 4.3 [Generics](./AdvancedCSharp/Generics/)

---

## C# Fundamentals

### 1.1 Variables and Data Types
Learned how to declare and initialize variables of different types including:

```csharp
int age = 25;
double price = 19.99;
char grade = 'A';
string name = "John Doe";
bool isStudent = true;
````

Also explored **implicit typing** with `var` and how variable types cannot be changed once assigned.

---

### 1.2 Control Structures

Covered conditional statements and loops:

* **If-else and switch statements**
* **For, While, and Foreach loops**

Example:

```csharp
int score = 85;
if (score >= 90) { Console.WriteLine("Grade: A"); }
else if (score >= 80) { Console.WriteLine("Grade: B"); }
else { Console.WriteLine("Grade: C or below"); }
```

---

### 1.3 Methods

Learned how to define reusable methods:

* Methods with no parameters
* Methods with parameters and return values
* Optional parameters

Example:

```csharp
int AddNumbers(int a, int b) { return a + b; }
void PrintMessage(string message, int times = 1) { ... }
```

---

## Object-Oriented Programming (OOP)

### 2.1 Classes and Objects

Understanding classes as blueprints and objects as instances:

```csharp
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public void Introduce() { Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old."); }
}
Person person1 = new Person("Alice", 30);
person1.Introduce();
```

---

### 2.2 Encapsulation

Hiding internal details and controlling access with properties and methods:

```csharp
private decimal balance;
public decimal Balance { get { return balance; } private set { balance = value; } }
public void Deposit(decimal amount) { ... }
public bool Withdraw(decimal amount) { ... }
```

---

### 2.3 Inheritance

Allowing a class to inherit members from another class:

```csharp
public class Animal { public string Name { get; set; } public virtual void MakeSound() { ... } }
public class Dog : Animal { public override void MakeSound() { Console.WriteLine("Woof! Woof!"); } }
```

---

### 2.4 Polymorphism

Demonstrated **compile-time** (method overloading) and **runtime** (method overriding) polymorphism:

```csharp
Calculator calc = new Calculator();
calc.Add(5, 3);        // Overloading
Shape shape = new Circle { Radius = 5 };
shape.CalculateArea();  // Overriding
```

---

### 2.5 Abstraction

Hiding complex details with abstract classes and forcing implementation in derived classes:

```csharp
public abstract class Vehicle
{
    public string Brand { get; set; }
    public abstract void Start();
}
public class Car : Vehicle { public override void Start() { Console.WriteLine("Car engine started"); } }
```

---

## Collections and LINQ

### 3.1 Collections

Learned to use:

* **List<T>**, **Array**, **Dictionary<TKey, TValue>**
* **Queue<T>** (FIFO) and **Stack<T>** (LIFO)

Example:

```csharp
List<string> names = new List<string> { "Alice", "Bob" };
Dictionary<string,int> ages = new Dictionary<string,int> { { "Alice", 30 } };
```

---

### 3.2 LINQ

Querying collections using **query syntax** and **method syntax**:

```csharp
var evenNumbers = from num in numbers where num % 2 == 0 select num;
var topStudents = students.Where(s => s.Grade >= 90).OrderByDescending(s => s.Grade).Select(s => s.Name);
```

Also practiced **aggregation, grouping, and common LINQ methods** like `Any()`, `All()`, `Sum()`, `Average()`, `Distinct()`.

---

## Advanced C# Concepts

### 4.1 Asynchronous Programming

Learned **async/await** for non-blocking operations:

```csharp
public async Task<string> FetchDataAsync(string url) { await Task.Delay(2000); return $"Data from {url}"; }
```

* Running multiple tasks concurrently with `Task.WhenAll`
* Reading files asynchronously with `File.ReadAllTextAsync`

---

### 4.2 Exception Handling

Handling errors gracefully:

```csharp
try { int result = a / b; }
catch (DivideByZeroException) { Console.WriteLine("Cannot divide by zero!"); }
finally { Console.WriteLine("Operation completed."); }
```

* Created **custom exceptions** for validation
* Used `throw` to signal exceptional conditions

---

### 4.3 Generics

Writing **reusable, type-safe code** with generic classes and methods:

```csharp
public class Box<T> { public void Pack(T item) { ... } public T Unpack() { ... } }
Box<int> intBox = new Box<int>();
int maxInt = FindMax(10, 20);
```

* Generic constraints like `where T : IComparable<T>`

---

## Summary of Skills Learned

* Core C# syntax: variables, data types, control structures, methods
* Object-Oriented Programming: classes, objects, encapsulation, inheritance, polymorphism, abstraction
* Collections and LINQ for data manipulation
* Advanced concepts: async/await, exception handling, generics

This repository serves as a comprehensive record of my **progress learning C# and .NET**, with practical examples for each concept.

---

## Usage

* Clone the repository:

```bash
git clone https://github.com/natnael-eyuel-dev/dotnet-learning.git
```

* Navigate to any folder and run the examples using **.NET CLI**:

```bash
dotnet run
```

---

## Notes

* Each folder is organized by topic and contains a `Program.cs` file demonstrating the concept.
* Code examples are written to be simple, clear, and runnable.
* This repository is intended as a **personal learning journal** and reference.