# Keywords and Concepts in the Program

| **Keyword/Concept** | **Description** |
|---------------------|----------------|
| `using System` | Imports the System namespace, which provides essential classes and methods like `Console.WriteLine()`. |
| `using System.Collections.Generic` | Enables the use of generic collections like `List<T>`. |
| `class Program` | Defines a class named `Program`, which contains the `Main` method (entry point of the program). |
| `static void Main()` | The main method where program execution begins. It is `static` because it doesn't require an object instance. |
| `List<string>` | A generic collection that stores a dynamic list of strings. It allows adding, removing, and accessing elements. |
| `while (true)` | Creates an infinite loop that keeps running until explicitly exited. Used for the main menu. |
| `Console.WriteLine()` | Prints output to the console. |
| `Console.Write()` | Similar to `WriteLine()` but does not move to a new line after printing. |
| `Console.ReadLine()` | Reads input from the user as a string. |
| `Trim()` | Removes leading and trailing spaces from user input. |
| `if (string.IsNullOrEmpty(value))` | Checks if a string is null or empty to prevent invalid input. |
| `items.Add(itemToAdd);` | Adds a new item to the list. |
| `items.RemoveAt(index - 1);` | Removes an item from the list at a specific index (converted to 0-based index). |
| `for (int i = 0; i < items.Count; i++)` | Iterates through the list and displays each item with a number. |
| `int.TryParse(input, out indexToRemove)` | Attempts to convert user input to an integer and prevents crashes if invalid input is given. |
| `return;` | Exits the program when the user selects option `4`. |
| `switch (choice)` | A control structure that executes different blocks of code based on the user's input. |
| `case "1":` | A specific condition inside the `switch` statement. Executes code when the user enters `"1"`. |
| `break;` | Exits the current `case` block in a `switch` statement to prevent fall-through. |
