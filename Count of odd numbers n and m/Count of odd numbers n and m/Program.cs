using System;
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Count(5, 18);
        }

        static void Count(int n, int m)
        {
            int count = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}