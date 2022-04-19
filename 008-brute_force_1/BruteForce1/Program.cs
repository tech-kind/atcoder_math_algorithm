using System;

class Program
{
    static void Main(string[] args)
    {
        string[] split = Console.ReadLine().Split(' ');
        int n = int.Parse(split[0]);
        int s = int.Parse(split[1]);

        int[,] dp = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                dp[i, j] = i + 1 + j + 1;
            }
        }

        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (dp[i, j] <= s)
                {
                    count++;
                }
            }
        }
        Console.WriteLine($"{count}");
    }
}
