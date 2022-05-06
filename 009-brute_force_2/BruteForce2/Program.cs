using System;

class Program
{
    static void Main(string[] args)
    {
        string[] vs = Console.ReadLine().Split(' ');
        long n = long.Parse(vs[0]);
        long s = long.Parse(vs[1]);

        string[] array = Console.ReadLine().Split(' ');
        long[] an = new long[n + 1];
        for (int i = 1; i <= n; i++)
        {
            an[i] = long.Parse(array[i - 1]);
        }

        long[,] dp = new long[n + 1, s + 1];

        // 動的計画法
        for (int i= 1; i <= n; i++)
        {
            for (int j = 0; j <= s; j++)
            {
                if (j < an[i])
                {
                    dp[i, j] = dp[i - 1, j];
                }
                // 整数Aiを選んだときにちょうどjとなる場合は、選択する
                else if ((dp[i - 1, j - an[i]] + an[i]) == j)
                {
                    dp[i, j] = j;
                }
                else
                {
                    dp[i, j] = dp[i - 1, j];
                }
            }
        }

        string ans = "No";
        for (int i = 0; i <= s; i++)
        {
            if (dp[n, i] == s)
            {
                ans = "Yes";
            }
        }

        Console.WriteLine($"{ans}");
    }
}
