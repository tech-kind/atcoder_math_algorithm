using System;

class Program
{
    static void Main(string[] args)
    {
        string[] split = Console.ReadLine().Split(' ');
        int n = int.Parse(split[0]);
        int x = int.Parse(split[1]);
        int y = int.Parse(split[2]);

        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            if ((i % x) == 0 || (i % y) == 0)
            {
                count++;
            }
        }

        Console.WriteLine($"{count}");
    }
}
