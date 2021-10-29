using System;

namespace Lab_5_on_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            long a, b;
            Console.WriteLine("Enter a");
            a = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine();
            for (long i =a; i<=b;i++)
            {
                Console.WriteLine("divisors of "+Convert.ToString(i));
                for (long j = 1; j<=i; j++)
                {
                    if (i % j == 0)
                    {
                        Console.Write(Convert.ToString(j)+" ");
                    } 
                }
                Console.WriteLine();
                Console.WriteLine();

            }
        }
    }
}
