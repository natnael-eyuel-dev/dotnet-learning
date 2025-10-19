// C# Collections and LINQ - 3.2 LINQ

using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsAndLINQ.LINQ
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ----- Simple LINQ Example -----
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Query syntax (SQL-like)
            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            Console.WriteLine("Even numbers (query syntax):");
            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }

            // Method syntax (lambda expressions)
            var evenNumbersMethod = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even numbers (method syntax):");
            foreach (var n in evenNumbersMethod)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();

            // ----- LINQ with Objects -----
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Age = 22, Grade = 85 },
                new Student { Name = "Bob", Age = 20, Grade = 92 },
                new Student { Name = "Charlie", Age = 23, Grade = 78 },
                new Student { Name = "Diana", Age = 21, Grade = 95 }
            };

            // Filter and select top students
            var topStudents = students
                .Where(s => s.Grade >= 90)
                .OrderByDescending(s => s.Grade)
                .Select(s => s.Name);

            Console.WriteLine("Top students:");
            foreach (var name in topStudents)
            {
                Console.WriteLine(name); // Output: Diana, Bob
            }
            Console.WriteLine();

            // Aggregations
            int averageAge = (int)students.Average(s => s.Age);
            int highestGrade = students.Max(s => s.Grade);
            int totalStudents = students.Count();

            Console.WriteLine($"Average Age: {averageAge}");
            Console.WriteLine($"Highest Grade: {highestGrade}");
            Console.WriteLine($"Total Students: {totalStudents}");
            Console.WriteLine();

            // Grouping
            var studentsByAge = students.GroupBy(s => s.Age);

            Console.WriteLine("Students grouped by age:");
            foreach (var group in studentsByAge)
            {
                Console.WriteLine($"Age {group.Key}:");
                foreach (var student in group)
                {
                    Console.WriteLine($"  - {student.Name}");
                }
            }

            Console.WriteLine();

            // Common LINQ methods reference (for demonstration)
            bool anyAbove90 = students.Any(s => s.Grade > 90);
            bool allAbove50 = students.All(s => s.Grade > 50);
            int sumGrades = students.Sum(s => s.Grade);
            var distinctGrades = students.Select(s => s.Grade).Distinct();

            Console.WriteLine($"Any grade above 90: {anyAbove90}");
            Console.WriteLine($"All grades above 50: {allAbove50}");
            Console.WriteLine($"Sum of grades: {sumGrades}");
            Console.WriteLine("Distinct grades: " + string.Join(", ", distinctGrades));
        }
    }
}

/* Expected Output when running 'dotnet run'

Even numbers (query syntax):
2
4
6
8
10
Even numbers (method syntax):
2
4
6
8
10

Top students:
Diana
Bob

Average Age: 21
Highest Grade: 95
Total Students: 4

Students grouped by age:
Age 22:
  - Alice
Age 20:
  - Bob
Age 23:
  - Charlie
Age 21:
  - Diana

Any grade above 90: True
All grades above 50: True
Sum of grades: 350
Distinct grades: 85, 92, 78, 95
*/