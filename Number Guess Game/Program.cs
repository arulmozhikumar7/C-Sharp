using System;

namespace NumberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int answer = num.Next(1, 101);
            int no_of_guesses = 0;

            Console.WriteLine("Guess the number (Between 1 and 100):");

            int user_input;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out user_input))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                if (user_input == answer)
                {
                    break;
                }
                else if (user_input > answer)
                {
                    Console.WriteLine("Try a lesser number.");
                }
                else
                {
                    Console.WriteLine("Try a greater number.");
                }

                no_of_guesses++;
            } while (true);

            Console.WriteLine("Success! You've guessed the number right.");
            Console.WriteLine($"You've guessed the number in {no_of_guesses} guesses.");
        }
    }
}
