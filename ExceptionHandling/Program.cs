using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int result = 100 / number;

            Console.WriteLine($"Result = {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("You cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number.");
        }
        finally
        {
            Console.WriteLine("Program finished.");
        }
    }
}