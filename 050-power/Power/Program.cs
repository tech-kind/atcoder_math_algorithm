using System;

class Program
{
    static void Main(string[] args)
    {
        string[] vs = Console.ReadLine().Split(' ');
        long a = long.Parse(vs[0]);
        long b = long.Parse(vs[1]);

        long m = 1000000007;

        Console.WriteLine($"{ModPow(a, b, m)}");
    }

    static long ModPow(long a, long b, long m)
    {
        long p = a;
        long ans = 1;

        for(int i= 0; i < 30; i++)
        {
            if ((b & (1 << i)) != 0)
            {
                ans *= p;
                ans %= m;
            }
            p *= p;
            p %= m;
        }
        return ans;
    }
}
