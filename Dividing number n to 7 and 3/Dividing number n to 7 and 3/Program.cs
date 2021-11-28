using System;
namespace Methods
    { 
    class Program
    {
        static void Main(string[] args)
        {
            Dividing(42);
            }
        static void Dividing(int n)
        {
            if (n % 21 == 0)
            {
                Console.WriteLine("Divided");
            }
            else
            {
                Console.WriteLine("Not divided");
            }
        } 
        }
    }

