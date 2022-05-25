using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        long sum = 0;
        for (long i = 1; i <= n; i++)
        {
            long x = n / i;
            sum += i * x * (x + 1) / 2;
        }

        Console.WriteLine($"{sum}");
    }
}
