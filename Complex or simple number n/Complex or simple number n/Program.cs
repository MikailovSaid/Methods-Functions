using System;
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Num(11);
        }

        static void Num(int n)
        {
            
            int count = 0;
            if (n <= 1)
            {
                Console.WriteLine("Enter correct number");
            }
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count > 2)
            {
                Console.WriteLine("Complex");
            }
            else
            {
                Console.WriteLine("Simple");
            }
        }
    }
}
