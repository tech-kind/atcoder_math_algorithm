using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] split = Console.ReadLine().Split(' ');

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += int.Parse(split[i]);
        }

        Console.WriteLine($"{sum}");
    }
}
