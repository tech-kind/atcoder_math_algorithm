using System;

class Program
{
    static void Main(string[] args)
    {
        string[] vs = Console.ReadLine().Split(' ');

        int a = int.Parse(vs[0]);
        int b = int.Parse(vs[1]);
        int h = int.Parse(vs[2]);
        int m = int.Parse(vs[3]);

        // 時針は1分間に0.5度回転する
        double hourDegree = h * 60.0 * 0.5 + m * 0.5;
        // 分針は1分間に6度回転する
        double minuteDegree = m * 6.0;

        // ラジアンに変換
        double hourAngle = Math.PI * hourDegree / 180.0;
        double minuteAngle = Math.PI * minuteDegree / 180.0;

        // 時針の回転
        double rotateAx = Math.Sin(hourAngle) * a;
        double rotateAy = Math.Cos(hourAngle) * a;
        // 分針の回転
        double rotateBx = Math.Sin(minuteAngle) * b;
        double rotateBy = Math.Cos(minuteAngle) * b;

        double ans = Math.Sqrt(Math.Pow(rotateAx - rotateBx, 2) + Math.Pow(rotateAy - rotateBy, 2));

        Console.WriteLine($"{ans}");
    }
}
