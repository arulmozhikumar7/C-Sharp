using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncMultiThreadingDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Fetching data from multiple sources...");

            try
            {
                var results = await FetchAllDataAsync();

                Console.WriteLine("\nAll data fetched successfully:\n");
                foreach (var result in results)
                {
                    Console.WriteLine(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nAn error occurred: {ex.Message}");
            }
        }

        // Fetches data from multiple sources concurrently
        static async Task<List<string>> FetchAllDataAsync()
        {
            var tasks = new List<Task<string>>
            {
                FetchFromSourceAsync("Source A", 2000),
                FetchFromSourceAsync("Source B", 1500),
                FetchFromSourceAsync("Source C", 2500, throwError: true), // Simulate error
                FetchFromSourceAsync("Source D", 1000)
            };

            var results = new List<string>();

            foreach (var task in tasks)
            {
                try
                {
                    results.Add(await task);
                }
                catch (Exception ex)
                {
                    results.Add($"Error from one source: {ex.Message}");
                }
            }

            return results;
        }

        // Simulated async data fetcher
        static async Task<string> FetchFromSourceAsync(string sourceName, int delayMs, bool throwError = false)
        {
            await Task.Delay(delayMs); // Simulate delay

            if (throwError)
                throw new Exception($"Failed to fetch from {sourceName}");

            return $"{sourceName}: Data received after {delayMs}ms";
        }
    }
}
