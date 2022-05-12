using System;

class Program
{
    static void Main(string[] args)
    {
        string[] vs1 = Console.ReadLine().Split(' ');
        string[] vs2 = Console.ReadLine().Split(' ');
        string[] vs3 = Console.ReadLine().Split(' ');
        string[] vs4 = Console.ReadLine().Split(' ');

        long x1 = long.Parse(vs1[0]);
        long y1 = long.Parse(vs1[1]);
        long x2 = long.Parse(vs2[0]);
        long y2 = long.Parse(vs2[1]);
        long x3 = long.Parse(vs3[0]);
        long y3 = long.Parse(vs3[1]);
        long x4 = long.Parse(vs4[0]);
        long y4 = long.Parse(vs4[1]);

        // 交差判定
        double s1 = (x1 - x2) * (y3 - y1) - (y1 - y2) * (x3 - x1);
        double t1 = (x1 - x2) * (y4 - y1) - (y1 - y2) * (x4 - x1);

        double s2 = (x3 - x4) * (y1 - y3) - (y3 - y4) * (x1 - x3);
        double t2 = (x3 - x4) * (y2 - y3) - (y3 - y4) * (x2 - x3);

        string ans = string.Empty;
        if ((s1 * t1) > 0 || (s2 * t2) > 0)
        {
            ans = "No";
        }
        else
        {
            // 直線の延長線上で交差するものについては除外するための判定処理
            if (Math.Min(x1, x2) <= Math.Max(x3, x4) && Math.Min(x3, x4) <= Math.Max(x1, x2)
                && Math.Min(y1, y2) <= Math.Max(y3, y4) && Math.Min(y3, y4) <= Math.Max(y1, y2))
            {
                ans = "Yes";
            }
            else
            {
                ans = "No";
            }
        }

        Console.WriteLine($"{ans}");
    }
}
