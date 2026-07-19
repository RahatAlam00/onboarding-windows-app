using System;

class Program
{
    static void Main()
    {
        // Different data types
        int age = 25;
        string name = "Alice";
        bool isStudent = true;
        double height = 1.68;

        // Constant
        const double Pi = 3.14159;

        // Operators
        int nextYearAge = age + 1;
        bool isAdult = age >= 18;

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Student: {isStudent}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Pi: {Pi}");
        Console.WriteLine($"Age Next Year: {nextYearAge}");
        Console.WriteLine($"Adult: {isAdult}");

        // Type conversion
        string numberText = "100";
        int number = Convert.ToInt32(numberText);

        Console.WriteLine($"Converted Number: {number}");

        double result = number / 3.0;

        Console.WriteLine($"Division Result: {result}");

        // Safe type conversion using TryParse
        string invalidInput = "abc";

        bool success = int.TryParse(invalidInput, out int parsedNumber);

        Console.WriteLine($"Conversion successful: {success}");
        Console.WriteLine($"Parsed number: {parsedNumber}");
    }
}
