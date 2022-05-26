using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var sw = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
        Console.SetOut(sw);

        string[] vs = Console.ReadLine().Split(' ');

        int n = int.Parse(vs[0]);
        int m = int.Parse(vs[1]);
        
        int[] arrayA = new int[100009];
        int[] arrayB = new int[100009];
        int[] dist = new int[100009];
        List<int>[] graph = new List<int>[100009];

        // 初期化
        for (int i = 0; i < 100009; i++)
        {
            dist[i] = -1;
            graph[i] = new List<int>();
        }

        for (int i = 1; i <= m; i++)
        {
            string[] vs2 = Console.ReadLine().Split(' ');
            graph[int.Parse(vs2[0])].Add(int.Parse(vs2[1]));
            graph[int.Parse(vs2[1])].Add(int.Parse(vs2[0]));
        }

        Queue<int> q = new Queue<int>();
        q.Enqueue(1);
        dist[1] = 0;

        // 幅優先探索
        while (q.Count > 0)
        {
            // qの先頭を調べる
            int pos = q.Peek();
            // qの先頭を取り出す
            q.Dequeue();

            for (int i = 0; i < graph[pos].Count; i++)
            {
                int nex = graph[pos][i];
                if (dist[nex] == -1)
                {
                    dist[nex] = dist[pos] + 1;
                    // qにnexを追加
                    q.Enqueue(nex);
                }
            }
        }

        // 頂点1から各頂点までの最短距離を出力
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{dist[i]}");
        }

        Console.Out.Flush();
    }
}
