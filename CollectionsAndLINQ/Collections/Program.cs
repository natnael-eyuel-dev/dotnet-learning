// C# Collections - 3.1 Collections

using System;
using System.Collections.Generic;

namespace CollectionsAndLINQ.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- List<T> (Dynamic Array) -----
            List<string> names = new List<string>();
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");

            Console.WriteLine("Names in the list:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"Count: {names.Count}");
            Console.WriteLine();

            // ----- Array (Fixed Size) -----
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Numbers in the array:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // ----- Dictionary<TKey, TValue> (Key-Value Pairs) -----
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                { "Alice", 30 },
                { "Bob", 25 },
                { "Charlie", 35 }
            };

            Console.WriteLine("Dictionary of ages:");
            foreach (var kvp in ages)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            Console.WriteLine($"Bob's age: {ages["Bob"]}");
            Console.WriteLine();

            // ----- Queue<T> (FIFO) -----
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");

            Console.WriteLine("Queue operations:");
            string first = queue.Dequeue();
            Console.WriteLine($"Dequeued: {first}");
            Console.WriteLine();

            // ----- Stack<T> (LIFO) -----
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);

            Console.WriteLine("Stack operations:");
            int last = stack.Pop();
            Console.WriteLine($"Popped: {last}");
        }
    }
}

/* Expected Output when running 'dotnet run'

Names in the list:
Alice
Bob
Charlie
Count: 3

Numbers in the array:
1
2
3
4
5

Dictionary of ages:
Alice: 30
Bob: 25
Charlie: 35
Bob's age: 25

Queue operations:
Dequeued: First

Stack operations:
Popped: 2
*/