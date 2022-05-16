using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] vs = Console.ReadLine().Split(' ');

        long n = long.Parse(vs[0]);
        long q = long.Parse(vs[1]);

        long[] array = new long[n + 2];
        long[] l = new long[q + 1];
        long[] r = new long[q + 1];
        long[] x = new long[q + 1];

        for (int i = 1; i <= q; i++)
        {
            string[] vs2 = Console.ReadLine().Split(' ');
            l[i] = long.Parse(vs2[0]);
            r[i] = long.Parse(vs2[1]);
            x[i] = long.Parse(vs2[2]);
            array[l[i]] += x[i];
            array[r[i] + 1] -= x[i];
        }

        StringBuilder sb = new StringBuilder();

        for (int i = 2; i <= n; i++)
        {
            if (array[i] > 0)
            {
                sb.Append("<");
            }
            if (array[i] == 0)
            {
                sb.Append("=");
            }
            if (array[i] < 0)
            {
                sb.Append(">");
            }
        }

        Console.WriteLine($"{sb.ToString()}");
    }
}
