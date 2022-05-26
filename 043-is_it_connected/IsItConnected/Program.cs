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
        bool[] visited = new bool[100009];

        List<int>[] graph = new List<int>[100009];
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

        Dfs(1, ref visited, ref graph);

        bool ans = true;
        for (int i = 1; i <= n; i++)
        {
            if (visited[i] == false)
            {
                ans = false;
            }
        }

        string msg = ans ? "The graph is connected." : "The graph is not connected.";
        Console.WriteLine($"{msg}");
    }

    static void Dfs(int pos, ref bool[] visited, ref List<int>[] graph)
    {
        visited[pos] = true;

        foreach (var item in graph[pos])
        {
            if (visited[item] == false)
            {
                Dfs(item, ref visited, ref graph);
            }
        }
    }
}
