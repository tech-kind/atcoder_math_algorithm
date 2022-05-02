using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        double ans = 1.0;
        for (int i = 1; i < n; i++)
        {
            ans += 1.0 / (1.0 - (1.0 * i / n));
        }

        Console.WriteLine($"{ans}");
    }
}
