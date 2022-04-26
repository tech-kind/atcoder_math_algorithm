using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] split = Console.ReadLine().Split(' ');
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(split[i]);
        }

        int ans = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    for (int l = k + 1; l < n; l++)
                    {
                        for (int m = l + 1; m < n; m++)
                        {
                            if (array[i] + array[j] + array[k] + array[l] + array[m] == 1000)
                                ans++;
                        }
                    }
                }
            }
        }

        Console.WriteLine($"{ans}");
    }
}
