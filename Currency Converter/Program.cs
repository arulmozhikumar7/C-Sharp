using System;
using System.Collections.Generic;

namespace CurrencyConverterApp
{
    class Program
    {
        static Dictionary<string, double> exchangeRates = new Dictionary<string, double>
        {
            { "USD", 1.0 },
            { "EUR", 0.82 },
            { "GBP", 0.71 },
            { "INR", 83.39 }
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Available currencies:");
                foreach (string currency in exchangeRates.Keys)
                {
                    Console.WriteLine(currency);
                }

              
                string sourceCurrency;
                do
                {
                    Console.Write("Enter the source currency: ");
                    sourceCurrency = Console.ReadLine().ToUpper();
                    if (!exchangeRates.ContainsKey(sourceCurrency))
                    {
                        Console.WriteLine("Invalid source currency. Please enter a valid currency.");
                    }
                } while (!exchangeRates.ContainsKey(sourceCurrency));

               
                string targetCurrency;
                do
                {
                    Console.Write("Enter the target currency: ");
                    targetCurrency = Console.ReadLine().ToUpper();
                    if (!exchangeRates.ContainsKey(targetCurrency))
                    {
                        Console.WriteLine("Invalid target currency. Please enter a valid currency.");
                    }
                } while (!exchangeRates.ContainsKey(targetCurrency));

                double amount;
                bool validAmount = false;
                do
                {
                    Console.Write("Enter the amount to convert: ");
                    string amountInput = Console.ReadLine();
                    validAmount = double.TryParse(amountInput, out amount);
                    if (!validAmount)
                    {
                        Console.WriteLine("Invalid amount. Please enter a valid number.");
                    }
                } while (!validAmount);

                double sourceRate = exchangeRates[sourceCurrency];
                double targetRate = exchangeRates[targetCurrency];
                double convertedAmount = amount / sourceRate * targetRate;
                Console.WriteLine($"{amount} {sourceCurrency} = {convertedAmount} {targetCurrency}");

                Console.WriteLine("Do you want to continue? (yes/no)");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == "no")
                {
                    Console.WriteLine("Thanks for using Currency Converter");
                    break;
                }
            }
        }
    }
}
