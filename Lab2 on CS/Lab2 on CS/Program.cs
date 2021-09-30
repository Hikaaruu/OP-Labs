using System;

namespace Lab2_on_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Enter x");
            x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y");
            y = Convert.ToDouble(Console.ReadLine());
            if (Math.Pow(x, 2) + Math.Pow(y, 2) > 4)
                Console.WriteLine("point does not belong to the area");
            else if (x >= 0 && y >= 0 && y >= -x + 2)
                Console.WriteLine("point belongs to the area ");
            else if (x <= 0 && y <= 0 && y <= -x - 2)
                Console.WriteLine("point belongs to the area ");
            else if (x >= 0 && y <= 0 && y >= x - 2)
                Console.WriteLine("point belongs to the area ");
            else if (x <= 0 && y >= 0 && y <= x + 2)
                Console.WriteLine("point belongs to the area ");
            else if (Math.Pow(x,2)+ Math.Pow(y,2)==4)
                Console.WriteLine("point belongs to the area ");
            else 
                Console.WriteLine("point does not belong to the area");


        }
    }
}
