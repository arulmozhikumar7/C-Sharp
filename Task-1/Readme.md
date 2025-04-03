# Factorial Calculator in C#

## Description
This is a simple C# console application that calculates the factorial of a given number.  
The program:
- Takes user input.
- Validates that the input is a positive integer.
- Uses an iterative approach to compute the factorial.
- Displays the result.

---

## **Keywords Used in the Program**

### 1. `using System;`
- The `System` namespace contains fundamental classes such as `Console`, which allows input/output operations.

### 2. `class FactorialCalculator`
- Defines a **class** named `FactorialCalculator` that contains the methods used in the program.

### 3. `static long Factorial(int n)`
- Declares a **static method** named `Factorial` that takes an integer `n` and returns a `long` value.
- `static`: This means the method belongs to the class itself, not an instance.
- `long`: A data type that can store large integer values (useful for large factorial calculations).

### 4. `for (int i = 2; i <= n; i++)`
- A `for` loop that iterates from `2` to `n` to calculate the factorial.
- `result *= i;` multiplies `result` by `i` at each iteration.

### 5. `static void Main()`
- The **entry point** of the program where execution starts.

### 6. `Console.Write() / Console.WriteLine()`
- Used to print text to the console.
- `Console.Write()` prints on the same line.
- `Console.WriteLine()` prints on a new line.

### 7. `Console.ReadLine()`
- Reads user input from the console as a string.

### 8. `int.TryParse(Console.ReadLine(), out number)`
- `TryParse` converts the string input into an integer and stores it in `number`.
- Returns `true` if successful, otherwise `false`.

### 9. `while (true) {...}`
- A **loop** that runs indefinitely until a valid input is received.

### 10. `$"Factorial of {number} is: {result}"`
- String **interpolation** (`$""`) to insert variable values into the output string.

---


