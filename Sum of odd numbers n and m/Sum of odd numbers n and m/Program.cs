using System;
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(3, 5);
        }

        static void Sum(int n, int m)
        {
            var sum = 0;
            for (var i = n; i <= m; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}