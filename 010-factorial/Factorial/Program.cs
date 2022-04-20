using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        long result = Factorial(n);
        Console.WriteLine($"{result}");
    }

    static long Factorial(int number)
    {
        if (number == 1)
        {
            return number;
        }
        else if (number >= 2)
        {
            return number * Factorial(number - 1);
        }
        return 0;
    }
}
