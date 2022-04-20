using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();
        for (int i = 2; i <= n; i++)
        {
            if (i == 2)
            {
                sb.Append($"{i}");
                continue;
            }

            bool prime = true;
            for (int j = 2; j < i; j++)
            {
                if ( i % j == 0 )
                {
                    prime = false;
                }
            }
            if ( prime )
            {
                sb.Append($" {i}");
            }
        }

        Console.WriteLine(sb.ToString());
    }
}
