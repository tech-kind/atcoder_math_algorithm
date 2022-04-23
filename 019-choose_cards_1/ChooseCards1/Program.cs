using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] split = Console.ReadLine().Split(' ');

        Span<long> vs = stackalloc long[3];
        for(int i = 0; i < n; i++)
        {
            int value = int.Parse(split[i]);
            vs[value % 3]++;
        }

        long result = nCk(vs[0], 2) + nCk(vs[1], 2) + nCk(vs[2], 2);
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
