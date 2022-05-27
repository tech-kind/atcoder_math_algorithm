using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] vs = Console.ReadLine().Split(' ');

        int n = int.Parse(vs[0]);
        int m = int.Parse(vs[1]);
        
        int[] arrayA = new int[100009];
        int[] arrayB = new int[100009];
        List<int>[] graph = new List<int>[100009];

        // 初期化
        for (int i = 0; i < 100009; i++)
        {
            graph[i] = new List<int>();
        }

        for (int i = 1; i <= m; i++)
        {
            string[] vs2 = Console.ReadLine().Split(' ');
            graph[int.Parse(vs2[0])].Add(int.Parse(vs2[1]));
            graph[int.Parse(vs2[1])].Add(int.Parse(vs2[0]));
        }

        int ans = 0;
        for (int i = 1; i <= n; i++)
        {
            int count = 0;
            for (int j = 0; j < graph[i].Count; j++)
            {
                if (i > graph[i][j])
                {
                    count++;
                }
            }

            if (count == 1)
            {
                ans++;
            }
        }

        Console.WriteLine($"{ans}");
    }
}
