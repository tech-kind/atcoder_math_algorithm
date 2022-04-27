using System;

class Program
{
    static void Main(string[] args)
    {
        string[] split = Console.ReadLine().Split(' ');

        long n = long.Parse(split[0]);
        long r = long.Parse(split[1]);

        long result = nCk(n, r);
        Console.WriteLine($"{result}");
    }

    /// <summary>
    /// 組み合わせ (n >= k)
    /// </summary>
    static long nCk(long n, long k)
    {
        if (n < k) return 0;
        if (n == k) return 1;

        long x = 1;
        for (long i = 0; i < k; i++)
        {
            x = x * (n - i) / (i + 1);
        }
        return x;
    }
}
