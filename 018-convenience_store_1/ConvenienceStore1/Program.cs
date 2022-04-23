using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] split = Console.ReadLine().Split(' ');

        Span<long> vs = stackalloc long[4];
        for (int i = 0; i < n; i++)
        {
            int value = int.Parse(split[i]);
            vs[value / 100 - 1]++;
        }

        long result = (vs[0] * vs[3]) + (vs[1] * vs[2]);
        Console.WriteLine($"{result}");
    }
}
