using System;

class Program
{
    static void Main(string[] args)
    {
        string[] split = Console.ReadLine().Split(' ');

        long a = long.Parse(split[0]);
        long b = long.Parse(split[1]);

        long result = GCD(a, b);

        Console.WriteLine($"{result}");
    }

    static long GCD(long a, long b)
    {
        while (a >= 1 && b >= 1)
        {
            if (a < b)
                b = b % a;
            else
                a = a % b;
        }
        if (a >= 1)
            return a;
        else
            return b;
    }
}
