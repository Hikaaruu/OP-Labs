using System;

namespace Lab_1_OP
{
    class Program
    {
        static void Main(string[] args)
        {
            double kat1, gip, res;
            Console.WriteLine("Введите значение гипотенузы");
            gip = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение первого катета");
            kat1 = Convert.ToDouble(Console.ReadLine());
            res = Math.Sqrt(Math.Pow(gip, 2) - Math.Pow(kat1, 2));
            Console.WriteLine("Значение второго катета:" + res);

        }
    }
}
