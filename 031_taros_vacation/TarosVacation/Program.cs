using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] vs = Console.ReadLine().Split(' ');
        long[] an = new long[n + 1];

        for(int i = 1; i <= n; i++)
        {
            an[i] = long.Parse(vs[i - 1]);
        }

        long[] dp = new long[n + 1];
        for (int i = 1; i <= n; i++)
        {
            if (i == 1 || i == 2)
            {
                dp[i] = an[i];
            }
            if (i >= 3)
            {
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + an[i]);
            }
        }

        Console.WriteLine($"{dp[n]}");
    }
}
