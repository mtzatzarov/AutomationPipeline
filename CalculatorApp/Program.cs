using System;

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        // Example usage
        int sum = calculator.Add(5, 3);
        Console.WriteLine($"5 + 3 = {sum}");

        int difference = calculator.Subtract(10, 4);
        Console.WriteLine($"10 - 4 = {difference}");
    }
}