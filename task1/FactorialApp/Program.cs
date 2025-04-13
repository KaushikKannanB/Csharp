using System;
class Program  
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine()); 
        int fact = Factorial(num);
        Console.WriteLine($"Factorial of {num} is: {fact}");
    }

    static int Factorial(int n)  
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
