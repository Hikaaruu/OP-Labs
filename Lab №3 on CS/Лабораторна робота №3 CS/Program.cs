using System;

namespace Лабораторна_робота__3_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            double x0, x, nextx;
            Console.WriteLine("Enter a");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a <= 1) x0 = Math.Min(2 * a, 0.95);
            else if ((1 < a) && (a < 25)) x0 = a / 5;
            else x0 = a / 25;
            x = x0;
            nextx = ( ( 4 * x ) / 5 ) + ( a / ( 5 * ( Math.Pow(x, 4) ) ) );
            while (Math.Abs(x - nextx) >= 0.0001) 
                {
                    x = nextx;
                    nextx = ((4 * x) / 5) + (a / (5 * (Math.Pow(x, 4))));
                }
            Console.WriteLine(nextx);
            


        }
    }
}
