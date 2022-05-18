using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var sw = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
        Console.SetOut(sw);

        int t = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        // 変化時刻の人数の増減だけ確認する
        // 階差の配列を作成する
        long[] arrayB = new long[t + 1];
        for (int i = 0; i < n; i++)
        {
            string[] vs = Console.ReadLine().Split(' ');
            arrayB[int.Parse(vs[0])] += 1;
            arrayB[int.Parse(vs[1])] -= 1;
        }

        // 階差の配列から累積和をとりある時点での人数を求める
        long[] arrayA = new long[t + 1];
        arrayA[0] = arrayB[0];
        Console.WriteLine($"{arrayB[0]}");
        for (int i = 1; i < t; i++)
        {
            arrayA[i] = arrayA[i - 1] + arrayB[i];
            Console.WriteLine($"{arrayA[i]}");
        }

        Console.Out.Flush();
    }
}
