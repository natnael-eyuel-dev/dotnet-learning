// C# Advanced - 4.1 Asynchronous Programming

using System;
using System.IO;
using System.Threading.Tasks;

namespace AdvancedCSharp.AsyncProgramming
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting async example...\n");

            // Call async method to fetch data
            await ProcessDataAsync();

            // Optional: Read a file asynchronously 
            string filePath = "sample.txt"; 
            string fileContent = await ReadFileAsync(filePath);
            Console.WriteLine($"\nFile content:\n{fileContent}");
        }

        // Async method simulating fetching data
        public static async Task<string> FetchDataAsync(string url)
        {
            Console.WriteLine($"Starting to fetch data from {url}...");
            
            // Simulate network delay
            await Task.Delay(2000); // 2 seconds without blocking
            
            Console.WriteLine($"Data fetched from {url}!");
            return $"Data from {url}";
        }

        // Async method demonstrating multiple async operations
        public static async Task ProcessDataAsync()
        {
            string result = await FetchDataAsync("https://api.example.com");
            Console.WriteLine(result);

            // Multiple async tasks
            Task<string> task1 = FetchDataAsync("url1");
            Task<string> task2 = FetchDataAsync("url2");

            await Task.WhenAll(task1, task2);

            Console.WriteLine(task1.Result);
            Console.WriteLine(task2.Result);
        }

        // Async file reading
        public static async Task<string> ReadFileAsync(string filePath)
        {
            try
            {
                string content = await File.ReadAllTextAsync(filePath);
                return content;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                return string.Empty;
            }
        }
    }
}

/* Expected Output when running 'dotnet run'

Starting async example...

Starting to fetch data from https://api.example.com...
Data fetched from https://api.example.com!
Data from https://api.example.com
Starting to fetch data from url1...
Starting to fetch data from url2...
Data fetched from url2!
Data fetched from url1!
Data from url1
Data from url2

File content:
This is a sample text file.
It contains multiple lines.
C# async/await can read it without blocking the main thread.
End of file.
*/
