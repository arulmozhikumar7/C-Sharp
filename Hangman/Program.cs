using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordList = new List<string> { "csharp", "fullstack", "reactjs", "nodejs" };
            Random random = new Random();
            string wordToGuess = wordList[random.Next(wordList.Count)];
            char[] guessedWord = new string('_', wordToGuess.Length).ToCharArray();
            List<char> incorrectGuesses = new List<char>();
            int remainingAttempts = 6;

            while (remainingAttempts > 0 && new string(guessedWord) != wordToGuess)
            {
                Console.Clear();
                Console.WriteLine("Hangman Game");
                Console.WriteLine("============");
                Console.WriteLine($"Word: {new string(guessedWord)}");
                Console.WriteLine($"Incorrect Guesses: {string.Join(", ", incorrectGuesses)}");
                Console.WriteLine($"Remaining Attempts: {remainingAttempts}");
                Console.Write("Guess a letter: ");
                string input = Console.ReadLine().ToLower();

                if (input.Length != 1 || !char.IsLetter(input[0]))
                {
                    Console.WriteLine("Please enter a single valid letter.");
                    Console.ReadKey();
                    continue;
                }

                char guessedLetter = input[0];

                if (incorrectGuesses.Contains(guessedLetter) || guessedWord.Contains(guessedLetter))
                {
                    Console.WriteLine("You have already guessed that letter.");
                    Console.ReadKey();
                    continue;
                }

                if (wordToGuess.Contains(guessedLetter))
                {
                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == guessedLetter)
                        {
                            guessedWord[i] = guessedLetter;
                        }
                    }
                }
                else
                {
                    incorrectGuesses.Add(guessedLetter);
                    remainingAttempts--;
                }
            }

            Console.Clear();
            if (new string(guessedWord) == wordToGuess)
            {
                Console.WriteLine("Congratulations! You've guessed the word: " + wordToGuess);
            }
            else
            {
                Console.WriteLine("Game Over! The word was: " + wordToGuess);
            }
        }
    }
}
