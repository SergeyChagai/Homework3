using System;

namespace _5_local_max
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
                    Console.WriteLine();
                }

                Console.Write("Числа, максимальные среди своих соседей: ");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (i > 0 && i < arr.GetLength(0) - 1)          //общий случай для строк
                        {
                            if (j > 0 && j < arr.GetLength(1) - 1)      //общий случай для элементов строки
                            {
                                if (arr[i, j] > arr[i, j - 1] && arr[i, j] > arr[i, j + 1] && arr[i, j] > arr[i - 1, j] && arr[i, j] > arr[i + 1, j])
                                    Console.Write($"{arr[i, j]}, ");
                            }
                            else if (j == 0)                            //если строки в середине, но элемент крайний левый
                            {
                                if (arr[i, j] > arr[i, j + 1] && arr[i, j] > arr[i - 1, j] && arr[i, j] > arr[i + 1, j])
                                    Console.Write($"{arr[i, j]}, ");
                            }
                            else if (j == arr.GetLength(1) - 1)         //если строки в середине, но элемент крайний правый
                            {
                                if (arr[i, j] > arr[i, j - 1] && arr[i, j] > arr[i - 1, j] && arr[i, j] > arr[i + 1, j])
                                    Console.Write($"{arr[i, j]}, ");
                            }
                        }
                        else if (i == 0)                                //если строка сверху
                        {
                            if (j > 0 && j < arr.GetLength(1) - 1)
                            {
                                if (arr[i, j] > arr[i, j - 1] && arr[i, j] > arr[i, j + 1]  && arr[i, j] > arr[i + 1, j])
                                    Console.Write($"{arr[i, j]}, ");
                            }
                            else if (j == 0)
                            {
                                if (arr[i, j] > arr[i, j + 1] && arr[i, j] > arr[i + 1, j])
                                    Console.Write($"{arr[i, j]}, ");
                            }
                            else if (j == arr.GetLength(1) - 1)
                            {
                                if (arr[i, j] > arr[i, j - 1] && arr[i, j] > arr[i + 1, j])
                                    Console.Write($"{arr[i, j]}, ");
                            }
                        }
                        else if (i == arr.GetLength(0) - 1)             //если строка снизу
                        {
                            if (j > 0 && j < arr.GetLength(1) - 1)
                            {
                                if (arr[i, j] > arr[i, j - 1] && arr[i, j] > arr[i, j + 1] && arr[i, j] > arr[i - 1, j])
                                    Console.Write($"{arr[i, j]}, ");
                            }
                            else if (j == 0)
                            {
                                if (arr[i, j] > arr[i, j + 1] && arr[i, j] > arr[i - 1, j])
                                    Console.Write($"{arr[i, j]}, ");
                            }
                            else if (j == arr.GetLength(1) - 1)
                            {
                                if (arr[i, j] > arr[i, j - 1] && arr[i, j] > arr[i - 1, j])
                                    Console.Write($"{arr[i, j]}, ");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
