using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] split = Console.ReadLine().Split(' ');

        long[] array = new long[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = long.Parse(split[i]);
        }

        long tmp = array[0];
        for (int i = 1; i < n; i++)
        {
            long lcm = LCM(tmp , array [i]);
            tmp = lcm;
        }
        Console.WriteLine($"{tmp}");
    }

    static long LCM(long ga, long gb)
    {
        long a = ga;
        long b = gb;
        while (a >= 1 && b >= 1)
        {
            if (a < b)
                b = b % a;
            else
                a = a % b;
        }
        if (a >= 1)
            return ga / a * gb;
        else
            return ga / b * gb;
    }
}
