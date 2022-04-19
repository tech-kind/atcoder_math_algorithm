using System;

class Program
{
    static void Main(string[] args)
    {
        string[] split = Console.ReadLine().Split(' ');

        int a1 = int.Parse(split[0]);
        int a2 = int.Parse(split[1]);
        int a3 = int.Parse(split[2]);

        Console.WriteLine($"{a1 * a2 * a3}");
    }
}
