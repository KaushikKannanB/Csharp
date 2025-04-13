using System;


class Program  
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Number: ");
        string? input = Console.ReadLine(); // Read input as a nullable string

        if (!int.TryParse(input, out int num) || num <= 0) // Check for valid number
        {
            Console.WriteLine("Input should be a valid positive integer.");
            return;
        }
        int fact = Factorial(num);
        Console.WriteLine($"Factorial of {num} is: {fact}");
    }

    static int Factorial(int n)  // Parameter name corrected
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}
