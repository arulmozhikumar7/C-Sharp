using System;
using System.IO;

class FileProcessor
{
    static void Main()
    {
        string inputFilePath = "in.txt";  // Input file
        string outputFilePath = "out.txt"; // Output file

        try
        {
            // Read the content from the input file
            string content = File.ReadAllText(inputFilePath);

            // Process: Count words in the file
            int wordCount = content.Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;

            // Write result to output file
            File.WriteAllText(outputFilePath, $"Word Count: {wordCount}");

            Console.WriteLine($"Word count written to {outputFilePath}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: The input file was not found.");
        }
        catch (IOException e)
        {
            Console.WriteLine($"File error: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Unexpected error: {e.Message}");
        }
    }
}
