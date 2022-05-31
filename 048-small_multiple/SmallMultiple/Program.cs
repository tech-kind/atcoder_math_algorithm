using System;
using System.Collections.Generic;

class Program
{
    static int K;
    static int[,] Memo;
    static int[,] Vis;

    static int F(int Rest, int Mo)
    {
        if (Rest == 0 & Mo == 0) return 1;

        if (0 < Memo[Rest, Mo]) return Memo[Rest, Mo];
        if (Vis[Rest, Mo] != 0) return Memo[Rest, Mo] = 2;
        Vis[Rest, Mo] = 1;
 
        int Res = 2;
        for (int i = 0; i <= 9; i++) if (0 <= Rest - i)
        {
            if (F(Rest - i, (Mo * 10 + i) % K) == 1)
            {
                Res = 1;
                break;
            }
        }

        return Memo[Rest, Mo] = Res;
    }
    
    static void Main()
    {
        K = int.Parse(Console.ReadLine());

        Memo = new int[45, K];
        Vis = new int[45, K];
        int Ma = 0, k = K;
        while (0 < k)
        {
            Ma += k % 10;
            k /= 10;
        }

        for (int i = 1; i < Ma; i++)
        {
            if (F(i, 0) == 1)
            {
                Console.WriteLine(i);
                return;
            }
        }
 
        Console.WriteLine(Ma);
    }
}
