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
        
        int[] arrayA = new int[200009];
        int[] arrayB = new int[200009];
        int[] visited = new int[200009];

        List<int>[] graph = new List<int>[200009];
        for (int i = 0; i < 200009; i++)
        {
            visited[i] = -1;
            graph[i] = new List<int>();
        }

        for (int i = 1; i <= m; i++)
        {
            string[] vs2 = Console.ReadLine().Split(' ');
            graph[int.Parse(vs2[0])].Add(int.Parse(vs2[1]));
            graph[int.Parse(vs2[1])].Add(int.Parse(vs2[0]));
        }

        bool ans = true;
        for (int i = 1; i <= n; i++)
        {
            // 探索済みならスキップ
            if (visited[i] != -1)
            {
                continue;
            }
            // 深さ優先探索で二部グラフかどうかの判定を行う
            if (!Dfs(i, 0, ref visited, ref graph))
            {
                ans = false;
            }
        }

        string msg = ans ? "Yes" : "No";
        Console.WriteLine($"{msg}");
    }

    static bool Dfs(int pos, int color, ref int[] visited, ref List<int>[] graph)
    {
        visited[pos] = color;

        foreach (var item in graph[pos])
        {
            // 探索済み
            if (visited[item] != -1)
            {
                // 同色なら二部グラフではない
                if (visited[item] == color)
                {
                    return false;
                }
                continue;
            }
            // 色を変えて再帰的に処理
            if (!Dfs(item, 1 - color, ref visited, ref graph))
            {
                return false;
            }
        }
        return true;
    }
}
