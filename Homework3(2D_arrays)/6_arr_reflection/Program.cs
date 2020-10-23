using System;

namespace _6_arr_reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите количество строк таблицы: ");
                int s = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество элементов в строках таблицы: ");
                int c = Convert.ToInt32(Console.ReadLine());

                if (c == 1 || s == 1)
                {
                    Console.WriteLine("Таблица не может состоять из одной строки/элемента строки.");
                    continue;
                }
                int[,] arr = new int[s, c];
               
                Random r = new Random();

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = r.Next(-100, 99);
                        int current = arr[i, j];
                        if ((current > 0 && current / 10 != 0) || (current < 0 && ((current * -1) / 10) == 0))   //для более-менее красивого вывода
                            Console.Write(" ");
                        else if (current >= 0 && current / 10 == 0)
                            Console.Write("  ");
                        Console.Write($"{current} ");
                    }
                    Console.WriteLine("\n");
                }

                int[,] arr2 = new int[c, s];
                int x = arr2.GetLength(1);
                int y = arr2.GetLength(0);
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                        arr2[i, j] = arr[j, i];
                }

                Console.WriteLine("----------------------------------------------\n");
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        int current = arr2[i, j];
                        if ((current > 0 && current / 10 != 0) || (current < 0 && ((current * -1) / 10) == 0))   //для более-менее красивого вывода
                            Console.Write(" ");
                        else if (current >= 0 && current / 10 == 0)
                            Console.Write("  ");
                        Console.Write($"{current} ");
                    }
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
