using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] vs = Console.ReadLine().Split(' ');
        long[] array = new long[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = long.Parse(vs[i]);
        }

        Array.Sort(array);
        
        Console.WriteLine($"{string.Join(" ", array)}");
    }
}
