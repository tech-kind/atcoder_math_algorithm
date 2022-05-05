using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] dp = new int[n + 1];
        for (int i = 0; i <= n; i++)
        {
            if (i <= 1)
            {
                dp[i] = 1;
            }
            else
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
        }

        Console.WriteLine($"{dp[n]}");
    }
}
