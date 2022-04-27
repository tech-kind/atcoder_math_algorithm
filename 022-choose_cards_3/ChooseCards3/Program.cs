using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] split = Console.ReadLine().Split(' ');
        long[] vs = new long[100000];

        for (int i = 0; i < n; i++)
        {
            int value = int.Parse(split[i]);
            vs[value]++;
        }

        long count = 0;
        for (int i = 1; i < vs.Length / 2; i++)
        {
            count += vs[i] * vs[vs.Length - i];
        }
        count += nCk(vs[vs.Length / 2], 2);
        Console.WriteLine($"{count}");
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
