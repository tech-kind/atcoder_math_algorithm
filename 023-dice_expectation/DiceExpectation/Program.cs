using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] vs1 = Console.ReadLine().Split(' ');
        string[] vs2 = Console.ReadLine().Split(' ');

        int[] arrayB = new int[n];
        int[] arrayR = new int[n];

        for (int i = 0; i < n; i ++)
        {
            arrayB[i] = int.Parse(vs1[i]);
            arrayR[i] = int.Parse(vs2[i]);
        }

        double expectB = 0;
        double expectR = 0;
        for (int i = 0; i < n; i++)
        {
            expectB += 1.0 * arrayB[i] / n;
            expectR += 1.0 * arrayR[i] / n;
        }

        Console.WriteLine($"{expectB + expectR}");
    }
}
