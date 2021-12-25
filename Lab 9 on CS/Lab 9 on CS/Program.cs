using System;

namespace Lab_9_on_CS
{
    class Program
    {
        private static void Delete_Even_Words_and_Find_Biggest_of_them(string a)
        {
            int count = 0;
            string result = "";
            string word = "";
            string biggest_word = "";
            int i = 0;
            while (i < a.Length)
            {
                if (a[i] != ' ')
                {
                    count++;
                    if (count % 2 != 0)
                    {
                        while (i < a.Length && a[i] != ' ')
                        {
                            word += a[i];
                            i++;
                        }
                        result += word;
                        result += " ";
                        if (word.Length > biggest_word.Length)
                        {
                            biggest_word = word;
                        }
                        word = "";
                    }
                    else
                    {
                        while (i < a.Length && a[i] != ' ')
                        {
                            i++;
                        }
                    }

                }
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("результат :  " + result);
            Console.WriteLine();
            Console.WriteLine("найдовше непарне слово :  " + biggest_word);
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Delete_Even_Words_and_Find_Biggest_of_them(a);
        }
    }
}
