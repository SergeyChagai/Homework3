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
                int c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество элементов в строках таблицы: ");
                int s = Convert.ToInt32(Console.ReadLine());

                if (c == 1 || s == 1)
                {
                    Console.WriteLine("Таблица не может состоять из одного(-ой) элемента строки/строки.");
                    continue;
                }
                int[,] arr = new int[s, c];
                Random r = new Random();

                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    for (int j = 0; j < arr.GetLength(0); j++)
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
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    for (int j = i + 1; j < arr.GetLength(0); j++)
                    {
                        int temp = arr[i, j];
                        arr[i, j] = arr[j, i];
                        arr[j, i] = temp;
                    }
                }

                Console.WriteLine("----------------------------------------------\n");
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    for (int j = 0; j < arr.GetLength(0); j++)
                    {
                        if ((arr[i, j] > 0 && arr[i, j] / 10 != 0) || (arr[i, j] < 0 && ((arr[i, j] * -1) / 10) == 0))   //для более-менее красивого вывода
                            Console.Write(" ");
                        else if (arr[i, j] >= 0 && arr[i, j] / 10 == 0)
                            Console.Write("  ");
                        Console.Write($"{arr[i, j]} ");
                    }
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
