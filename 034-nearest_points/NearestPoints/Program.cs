using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        long[,] points = new long[n, 2];
        for (int i = 0; i < n; i++)
        {
            string[] vs = Console.ReadLine().Split(' ');
            points[i, 0] = long.Parse(vs[0]);
            points[i, 1] = long.Parse(vs[1]);
        }

        double ans = double.MaxValue;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                long dx = points[i, 0] - points[j, 0];
                long dy = points[i, 1] - points[j, 1];
                double distance = Math.Sqrt(dx * dx + dy * dy);
                if (distance < ans)
                {
                    ans = distance;
                }
            }
        }

        Console.WriteLine($"{ans}");
    }
}
