using System;

class Program
{
    static void Main(string[] args)
    {
        string[] vs = Console.ReadLine().Split(' ');
        long n = long.Parse(vs[0]);
        long w = long.Parse(vs[1]);

        long[] weight = new long[n + 1];
        long[] value = new long[n + 1];
        for (int i = 1; i <= n; i++)
        {
            string[] array = Console.ReadLine().Split(' ');
            weight[i] = long.Parse(array[0]);
            value[i] = long.Parse(array[1]);
        }

        long[,] dp = new long[n + 1, w + 1];

        // 配列の初期化
        dp[0, 0] = 0;
        for (int i = 1; i <= w; i++)
        {
            dp[0, i] = long.MinValue;
        }

        // 動的計画法
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j <= w; j++)
            {
                // 品物iは選ばない
                if (j < weight[i])
                {
                    dp[i, j] = dp[i - 1, j];
                }
                // 品物iを選ぶ場合と、選ばない場合との最大値を比較する
                if (j >= weight[i])
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - weight[i]] + value[i]);
                }
            }
        }

        long ans = 0;
        for (int i = 0; i <= w; i++)
        {
            ans = Math.Max(ans, dp[n, i]);
        }

        Console.WriteLine($"{ans}");
    }
}
