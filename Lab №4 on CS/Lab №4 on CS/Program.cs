using System;

namespace Lab__4_on_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double ai, sum, bi;
            sum = 0;
            Console.WriteLine("Enter n");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                if (i % 2 == 0) { ai = i / 2; bi = i + 7; }
                else { ai = i;bi = Math.Pow(i, 2); }
                sum = sum + Math.Pow((ai-bi),2);
            }
            Console.WriteLine(sum);
            }   


            
    }
}
