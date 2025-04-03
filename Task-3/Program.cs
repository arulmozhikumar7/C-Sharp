using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> items = new List<string>();

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Display Items");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine()!.Trim();

            switch (choice)
            {
                case "1":
                    string itemToAdd;
                    do
                    {
                        Console.Write("Enter item to add: ");
                        itemToAdd = Console.ReadLine()!.Trim();

                        if (string.IsNullOrEmpty(itemToAdd))
                            Console.WriteLine("Item cannot be empty. Try again.");
                    } while (string.IsNullOrEmpty(itemToAdd));

                    items.Add(itemToAdd);
                    Console.WriteLine($"Added: {itemToAdd.ToUpper()}");
                    break;

                case "2":
                    if (items.Count == 0)
                    {
                        Console.WriteLine("The list is empty. Nothing to remove.");
                        break;
                    }

                    Console.WriteLine("\nList of Items:");
                    for (int i = 0; i < items.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {items[i].ToUpper()}");
                    }

                    int indexToRemove;
                    while (true)
                    {
                        Console.Write("Enter the number of the item to remove: ");
                        string input = Console.ReadLine()!.Trim();

                        if (int.TryParse(input, out indexToRemove) && indexToRemove >= 1 && indexToRemove <= items.Count)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Enter a valid number from the list.");
                        }
                    }

                    Console.WriteLine($"Removed: {items[indexToRemove - 1].ToUpper()}");
                    items.RemoveAt(indexToRemove - 1);
                    break;

                case "3":
                    Console.WriteLine("\nList of Items:");
                    if (items.Count == 0)
                    {
                        Console.WriteLine("No items in the list.");
                    }
                    else
                    {
                        for (int i = 0; i < items.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {items[i].ToUpper()}");
                        }
                    }
                    break;

                case "4":
                    Console.WriteLine("Exiting program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }
}
