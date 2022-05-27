using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] vs = Console.ReadLine().Split(' ');

        int r = int.Parse(vs[0]);
        int c = int.Parse(vs[1]);

        int[,] dist = new int[52, 52];

        string[] vs2 = Console.ReadLine().Split(' ');
        string[] vs3 = Console.ReadLine().Split(' ');

        int sy = int.Parse(vs2[0]);
        int sx = int.Parse(vs2[1]);
        int gy = int.Parse(vs3[0]);
        int gx = int.Parse(vs3[1]);

        // 初期化
        for (int i = 1; i <= r; i++)
        {
            string row = Console.ReadLine();

            for (int j = 1; j <= row.Length; j++)
            {
                if (row.Substring(j - 1, 1).Contains("#"))
                {
                    dist[i, j] = -2;
                }
                else
                {
                    dist[i, j] = -1;
                }
            }
        }

        Queue<(int, int)> q = new Queue<(int, int)>();
        q.Enqueue((sy, sx));
        dist[sy, sx] = 0;

        // 幅優先探索
        while(q.Count > 0)
        {
            // qの先頭を調べる
            (int y, int x) pos = q.Peek();
            // qの先頭を取り出す
            q.Dequeue();

            // 左
            if (dist[pos.y, pos.x - 1] == -1)
            {
                dist[pos.y, pos.x - 1] = dist[pos.y, pos.x] + 1;
                q.Enqueue((pos.y, pos.x - 1));
            }
            // 右
            if (dist[pos.y, pos.x + 1] == -1)
            {
                dist[pos.y, pos.x + 1] = dist[pos.y, pos.x] + 1;
                q.Enqueue((pos.y, pos.x + 1));
            }
            // 上
            if (dist[pos.y - 1, pos.x] == -1)
            {
                dist[pos.y - 1, pos.x] = dist[pos.y, pos.x] + 1;
                q.Enqueue((pos.y - 1, pos.x));
            }
            // 下
            if (dist[pos.y + 1, pos.x] == -1)
            {
                dist[pos.y + 1, pos.x] = dist[pos.y, pos.x] + 1;
                q.Enqueue((pos.y + 1, pos.x));
            }
        }

        Console.WriteLine($"{dist[gy, gx]}");
    }
}
