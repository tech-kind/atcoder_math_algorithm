using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] arrayA = Console.ReadLine().Split(' ');
        string[] arrayB = Console.ReadLine().Split(' ');

        double ans = 0;
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(arrayA[i]);
            int b = int.Parse(arrayB[i]);
            ans += (1.0 * a / 3) + (1.0 * b * 2 / 3);
        }

        Console.WriteLine($"{ans}");
    }
}
