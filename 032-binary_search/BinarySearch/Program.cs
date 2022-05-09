using System;

class Program
{
    static void Main(string[] args)
    {
        string[] vs = Console.ReadLine().Split(' ');
        long n = long.Parse(vs[0]);
        long x = long.Parse(vs[1]);

        string[] an = Console.ReadLine().Split(' ');
        long[] array = new long[n + 1];
        for (int i = 1; i <= n; i++)
        {
            array[i] = long.Parse(an[i - 1]);
        }

        // 配列をソートしておく
        Array.Sort(array);

        long left = 1;
        long right = n;
        while(left <= right)
        {
            // 探索範囲の中央で分割する
            long mid = (left + right) / 2;
            if (array[mid] == x)
            {
                Console.WriteLine("Yes");
                return;
            }
            // 探索範囲を前半部分に絞る
            if (array[mid] > x)
            {
                right = mid - 1;
            }
            // 探索範囲を後半部分に絞る
            if (array[mid] < x)
            {
                left = mid + 1;
            }
        }

        Console.WriteLine("No");
    }
}
