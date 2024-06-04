using System;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Simple Calculator");
            string value ="y";
            do
            {
                Console.Write("Enter first number: ");
                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.Write("Enter second number: ");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.Write("Enter operator (+, -, *, /): ");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        Console.WriteLine($"Addition: {num1 + num2}");
                        break;
                    case "-":
                        Console.WriteLine($"Subtraction: {num1 - num2}");
                        break;
                    case "*":
                        Console.WriteLine($"Multiplication: {num1 * num2}");
                        break;
                    case "/":
                        if (num2 != 0)
                            Console.WriteLine($"Division: {num1 / (double)num2}");
                        else
                            Console.WriteLine("Cannot divide by zero.");
                        break;
                    default:
                        Console.WriteLine("Invalid operator. Please enter +, -, *, or /.");
                        break;
                }

                Console.Write("Do you want to continue (y/n): ");
                value = Console.ReadLine();
            } while (value.ToLower() == "y");
        }
    }
}
