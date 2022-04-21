using System;

class Program
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());

        bool isPrime = true;
        for (long i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        string result = isPrime ? "Yes" : "No";
        Console.WriteLine($"{result}");
    }
}
