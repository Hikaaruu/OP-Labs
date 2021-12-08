using System;

namespace Lab_7_on_CS
{
    class Program
    {
        private static void CreateArray(int m, int[] p,Random rnd)
        {
            Console.WriteLine("Generated array : ");
            Console.WriteLine();
            for (int i = 0; i <= m - 1; i++)
            {
                p[i] = rnd.Next(10);
                Console.WriteLine(p[i]);
            }
            Console.WriteLine();
        }

        private static int Calculate_d(int m, int [] p)
        {
            int d = 0;
            int max = p[0]; 
            for (int i = 1; i <= m - 1; i++)
            {
               if (p[i] > max)
                {
                    max = p[i];
                }
            }
            for (int i = 0; i <= m - 1; i++)
            {
                d += Convert.ToInt32(Math.Pow((max - p[i]), 2));
            }
            Console.WriteLine("d = " + d);
            Console.WriteLine();
            return d;
        }

        private static void Result(int [] p, int m, int d)
        {
            Console.WriteLine("Result :");
            Console.WriteLine();
            for (int i = 0; i <= m - 1; i++)
            {
                if ((i + 1) % 2 == 1)
                {
                    Console.WriteLine(p[i] - d);
                }
                else
                {
                    Console.WriteLine(p[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int [] p = new int [100000];
            Random rnd = new Random();
            Console.WriteLine("Enter the size m of the array");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            CreateArray(m, p, rnd);
            int d = Calculate_d(m, p);
            Result(p, m, d);
        }
    }
}
