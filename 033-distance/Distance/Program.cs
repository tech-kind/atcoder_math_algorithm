using System;

class Program
{
    static void Main(string[] args)
    {
        string[] arrayA = Console.ReadLine().Split(' ');
        string[] arrayB = Console.ReadLine().Split(' ');
        string[] arrayC = Console.ReadLine().Split(' ');

        long ax = long.Parse(arrayA[0]);
        long ay = long.Parse(arrayA[1]);
        long bx = long.Parse(arrayB[0]);
        long by = long.Parse(arrayB[1]);
        long cx = long.Parse(arrayC[0]);
        long cy = long.Parse(arrayC[1]);

        // ベクトルの成分表示を求める
        long BAx = ax - bx;
        long BAy = ay - by;
        long BCx = cx - bx;
        long BCy = cy - by;
        long CAx = ax - cx;
        long CAy = ay - cy;
        long CBx = bx - cx;
        long CBy = by - cy;

        // どのパターンに当てはまるかを判定する
        int pattern = 2;
        if (BAx * BCx + BAy * BCy < 0)
        {
            pattern = 1;
        }
        if (CAx * CBx + CAy * CBy < 0)
        {
            pattern = 3;
        }

        // 点と直線の距離を求める
        double ans = 0;
        // BAの距離が最短
        if (pattern == 1)
        {
            ans = Math.Sqrt(BAx * BAx + BAy * BAy);
        }
        // CAの距離が最短
        if (pattern == 3)
        {
            ans = Math.Sqrt(CAx * CAx + CAy * CAy);
        }
        // 点AとBCとの垂線が最短
        if (pattern == 2)
        {
            double S = Math.Abs(BAx * CAy - BAy * CAx);
            double BCLength = Math.Sqrt(BCx * BCx + BCy * BCy);
            ans = S / BCLength;
        }

        Console.WriteLine($"{ans}");
    }
}
