using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var sw = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
        Console.SetOut(sw);

        string[] vs1 = Console.ReadLine().Split(' ');
        int n = int.Parse(vs1[0]);
        int q = int.Parse(vs1[1]);

        string[] vs2 = Console.ReadLine().Split(' ');
        long[] arrayA = new long[n + 1];
        for (int i = 1; i <= n; i++)
        {
            arrayA[i] = long.Parse(vs2[i - 1]);
        }

        long[] arrayL = new long[q + 1];
        long[] arrayR = new long[q + 1];
        for (int i = 1; i <= q; i++)
        {
            string[] vs3 = Console.ReadLine().Split(' ');
            arrayL[i] = long.Parse(vs3[0]);
            arrayR[i] = long.Parse(vs3[1]);
        }

        long[] arrayB = new long[n + 1];
        arrayB[0] = 0;
        for (int i = 1; i <= n; i++)
        {
            arrayB[i] = arrayB[i - 1] + arrayA[i];
        }

        for (int i = 1; i <= q; i++)
        {
            Console.WriteLine($"{arrayB[arrayR[i]] - arrayB[arrayL[i] - 1]}");
        }

        Console.Out.Flush();
    }
}
