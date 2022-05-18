using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        long[] arrayB = new long[n];
        string[] vs = Console.ReadLine().Split(' ');
        
        // 累積和の配列を作成する
        arrayB[0] = 0;
        for (int i = 1; i < n; i++)
        {
            arrayB[i] = long.Parse(vs[i - 1]) + arrayB[i - 1];
        }

        int m = int.Parse(Console.ReadLine());

        int prePlace = 0;
        long ans = 0;
        for (int i = 1; i <= m; i++)
        {
            if (i == 1)
            {
                prePlace = int.Parse(Console.ReadLine());
            }
            else
            {
                // 現在位置と前の位置の距離差を累積和から求める
                int tmp = int.Parse(Console.ReadLine());
                if (tmp > prePlace)
                {
                    ans += arrayB[tmp - 1] - arrayB[prePlace - 1];
                }
                else
                {
                    ans += arrayB[prePlace - 1] - arrayB[tmp - 1];
                }
                prePlace = tmp;
            }
        }

        Console.WriteLine($"{ans}");
    }
}
