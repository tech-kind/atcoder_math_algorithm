using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var sw = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
        Console.SetOut(sw);

        long n = long.Parse(Console.ReadLine());

        double count = Math.Floor(Math.Sqrt(n));
        List<long> results = new List<long>();
        for (int i = 1; i <= count; i++)
        {
            if (n % i == 0)
            {
                results.Add(i);
                results.Add(n / i);
            }
        }

        foreach (long result in results)
        {
            Console.WriteLine(result);
        }

        Console.Out.Flush();
    }
}
