using System;

class Program
{
    static void Main(string[] args)
    {
        string[] circle1 = Console.ReadLine().Split(' ');
        string[] circle2 = Console.ReadLine().Split(' ');

        int x1 = int.Parse(circle1[0]);
        int y1 = int.Parse(circle1[1]);
        int r1 = int.Parse(circle1[2]);

        int x2 = int.Parse(circle2[0]);
        int y2 = int.Parse(circle2[1]);
        int r2 = int.Parse(circle2[2]);

        // なぜかMath.Powを使って累乗を計算しないとうまくいかない
        // double dist = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        double dist = Math.Sqrt(Math.Pow(x1 - x2, 2)+ Math.Pow(y1 - y2, 2));

        int type = 3;
        if (dist < Math.Abs(r1- r2))
        {
            type = 1;
        }
        else if (dist == Math.Abs(r1 - r2))
        {
            type = 2;
        }
        else if (dist == (r1 + r2))
        {
            type = 4;
        }
        else if (dist > (r1 + r2))
        {
            type = 5;
        }

        Console.WriteLine($"{type}");
    }
}
