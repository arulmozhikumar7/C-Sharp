using System;

class FactorialCalculator
{
    // Method to calculate factorial using iteration
    static long Factorial(int n)
    {
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static void Main()
    {
        int number;
        
        // Input validation loop
        while (true)
        {
            Console.Write("Enter a positive integer: ");
            if (int.TryParse(Console.ReadLine(), out number) && number >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
        
        // Calculate and display the factorial
        long result = Factorial(number);
        Console.WriteLine($"Factorial of {number} is: {result}");
    }
}
