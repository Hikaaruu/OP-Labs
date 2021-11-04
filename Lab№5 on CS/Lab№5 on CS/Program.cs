using System;

namespace Lab_5_on_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            long a1, b1;
            long sum, n;
            
            Console.WriteLine("Enter a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            if (a < 1) { 
             a1 = 1;
            }
            else  if (a % 1 != 0) { 
            a1 = Convert.ToInt32(a - (a % 1)+1); 
             } 
            else { a1 = Convert.ToInt32(a); }
            
            b1 = Convert.ToInt32(b - (b % 1));

            for (long i=a1; i<=b1;i++)
            {
                sum = 0;
                n = 0;
                Console.WriteLine("divisors of "+Convert.ToString(i));
                for (long j = 1; j<=i; j++)
                {
                    if (i % j == 0)
                    {
                        Console.Write(Convert.ToString(j)+" ");
                        n++;
                        sum += j;
                    } 
                }
                Console.WriteLine();
                Console.WriteLine("number of divisors = "+n);
                Console.WriteLine("their sum = " + sum);
                Console.WriteLine();
                Console.WriteLine();

            }
        }
    }
}
