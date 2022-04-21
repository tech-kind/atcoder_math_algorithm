using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var sw = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
        Console.SetOut(sw);

        long n = long.Parse(Console.ReadLine());

        long tmp = n;
        StringBuilder sb = new StringBuilder();
        while(true)
        {
            double count = Math.Floor(Math.Sqrt(tmp));

            bool isPrime = true;
            for (int i = 2; i <= count; i++)
            {
                if (tmp % i == 0)
                {
                    sb.Append($"{i} ");
                    tmp = tmp / i;
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                sb.Append($"{tmp}");
                break;
            }
        }

        Console.WriteLine(sb.ToString());
        Console.Out.Flush();
    }
}
