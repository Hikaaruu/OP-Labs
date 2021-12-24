using System;

namespace Lab_8_on_CS
{
    class Program
    {
        private static void PrintMatrix(int[,] a, int n)
        {
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    Console.Write((a[i, j]).ToString().PadRight(5));
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        private static void Max_Element(int [,] a)
        {
            Console.WriteLine("Максимальне значення кутових елементiв матрицi : " + a[0, 0]);
        }
        private static void CreateMatrix(int[,] a, int n)
        {
            int dir = 1;
            int dir1 = 1;
            int number = 1;
            int flag = 1;
            for (int cons = 2 * n - 2; cons >= 0; cons--)
            {
                if (flag == 1)
                {
                    for (int j = n - 1; j >= 0; j--)
                    {

                        if (dir < 0)
                        {
                            for (int i = 0; i <= n - 1; i++)
                            {
                                if (i + j == cons)
                                {
                                    a[i, j] = number;
                                    number++;
                                }
                            }
                            dir = -dir;
                        }
                        else
                        {
                            for (int i = n - 1; i >= 0; i--)
                            {
                                if (i + j == cons)
                                {
                                    a[i, j] = number;
                                    number++;
                                }
                            }
                            dir = -dir;
                        }

                    }
                    flag = -flag;
                }
                else
                {
                    for (int j = 0; j <=n-1; j++)
                    {

                        if (dir1 < 0)
                        {
                            for (int i = 0; i <= n - 1; i++)
                            {
                                if (i + j == cons)
                                {
                                    a[i, j] = number;
                                    number++;
                                }
                            }
                            dir1 = -dir1;
                        }
                        else
                        {
                            for (int i = n - 1; i >= 0; i--)
                            {
                                if (i + j == cons)
                                {
                                    a[i, j] = number;
                                    number++;
                                }
                            }
                            dir1 = -dir1;
                        }

                    }
                    flag = -flag;
                }
            }
        }
        static void Main(string[] args)
        {
            const int n = 6;
            int[,] a = new int[n, n];
            CreateMatrix(a, n);
            PrintMatrix(a, n);
            Console.WriteLine();
            Max_Element(a);
        }
    }
}
