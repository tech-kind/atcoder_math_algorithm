using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] split = Console.ReadLine().Split(' ');

        long[] array = new long[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = long.Parse(split[i]);
        }

        long tmp = array[0];
        for (int i = 1; i < n; i++)
        {
            long gcd = GCD(tmp, array[i]);
            tmp = gcd;
        }
        Console.WriteLine($"{tmp}");
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
