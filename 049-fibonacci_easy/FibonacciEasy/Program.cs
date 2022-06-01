using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        long[] array = new long[n + 1];
        array[1] = 1;
        array[2] = 1;

        for (int i = 3; i <= n; i++)
        {
            array[i] = (array[i - 1] + array[i - 2]) % 1000000007;
        }

        Console.WriteLine($"{array[n] % 1000000007}");
    }
}
