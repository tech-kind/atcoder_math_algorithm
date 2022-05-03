using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] vs = Console.ReadLine().Split(' ');
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(vs[i]);
        }

        int[] dp = new int[n];
        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                // 最初は移動しないのでコスト0
                dp[i] = 0;
            }
            if (i == 1)
            {
                dp[i] = Math.Abs(array[i] - array[i - 1]);
            }
            if (i >= 2)
            {
                // 1個前の足場からジャンプする場合
                int v1 = dp[i - 1] + Math.Abs(array[i] - array[i - 1]);
                // 2個前の足場からジャンプする場合
                int v2 = dp[i - 2] + Math.Abs(array[i] - array[i - 2]);
                // コストが小さい方を採用する
                dp[i] = Math.Min(v1, v2);
            }
        }

        Console.WriteLine($"{dp[n - 1]}");
    }
}
