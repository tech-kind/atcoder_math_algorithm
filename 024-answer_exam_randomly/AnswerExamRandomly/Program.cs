using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        double ans = 0;
        for (int i = 0; i < n; i++)
        {
            string[] vs = Console.ReadLine().Split(' ');
            int p = int.Parse(vs[0]);
            int q = int.Parse(vs[1]);
            ans += 1.0 * q / p;
        }

        Console.WriteLine($"{ans}");
    }
}
