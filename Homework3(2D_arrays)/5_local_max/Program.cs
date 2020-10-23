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
                int rep = 0;

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

                Console.Write("Числа, максимальные среди своих соседей: ");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        bool left = (j != 0 && arr[i, j] > arr[i, j - 1]) || j == 0;
                        bool right = (j != arr.GetLength(1) - 1 && arr[i, j] > arr[i, j + 1]) || j == arr.GetLength(1) - 1;
                        bool up = (i != 0 && arr[i, j] > arr[i - 1, j]) || i == 0;
                        bool down = (i != arr.GetLength(0) - 1 && arr[i, j] > arr[i + 1, j]) || i == arr.GetLength(0) - 1;
                        if (left && right && up && down)
                        {
                            rep++;
                            Console.Write($"{arr[i, j]} ");
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"Всего {rep}");
            }
        }
    }
}
