using System;

namespace Lab6_on_CS
{
    class Program
    {
        private static double Xi(double a, int i, double h)
        {
            return (a+(i*h)-(h/2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter n");
            int n = Convert.ToInt32(Console.ReadLine());
            double h1 = Math.PI / n;
            double h2 = (b - a) / n;
            double sum1 = 0;
            double sum2 = 0;
            for (int i=1; i<=n; i++)
            {
                sum1 += Math.Log(2 + Math.Sin(Xi(0, i, h1)));
                sum2 += Math.Pow(Math.Atan(Xi(a, i, h2)),2);
            }
            double res = sum1 * h1 + sum2 * h2;
            Console.WriteLine(res);
        }  
    }
}
