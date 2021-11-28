using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Arr());           
        }
        static int Arr()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var sum = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }
    }
}