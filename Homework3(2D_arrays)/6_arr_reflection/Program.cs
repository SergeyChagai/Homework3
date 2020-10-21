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
                    Console.WriteLine("Таблица не может состоять из одного(-ой) элемента строки/строки.");
                    continue;
                }
                int[,] arr = new int[s, c];
                Random r = new Random();

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = r.Next(-100, 100);
                        if ((arr[i, j] > 0 && arr[i, j] / 10 != 0) || (arr[i, j] < 0 && ((arr[i, j] * -1) / 10) == 0))   //для более-менее красивого вывода
                            Console.Write(" ");
                        else if (arr[i, j] >= 0 && arr[i, j] / 10 == 0)
                            Console.Write("  ");
                        Console.Write($"{arr[i, j]} ");
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
                        if ((arr2[i, j] > 0 && arr2[i, j] / 10 != 0) || (arr2[i, j] < 0 && ((arr2[i, j] * -1) / 10) == 0))   //для более-менее красивого вывода
                            Console.Write(" ");
                        else if (arr2[i, j] >= 0 && arr2[i, j] / 10 == 0)
                            Console.Write("  ");
                        Console.Write($"{arr2[i, j]} ");
                    }
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
