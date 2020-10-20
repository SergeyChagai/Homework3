using System;

namespace Homework3_2D_arrays_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите количество столбцов таблицы: ");
                int s = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество строк таблицы: ");
                int c = Convert.ToInt32(Console.ReadLine());

                int[,] tab = new int[c, s];
                Random r = new Random();

                for (int i = 0; i < tab.GetLength(0); i++)
                {
                    for (int j = 0; j < tab.GetLength(1); j++)
                    {
                        tab[i, j] = r.Next(-99, 99);
                        if (tab[i, j] > 0 || (tab[i, j] < 0 && ((tab[i, j] * -1) / 10) == 0))   //для более-менее красивого вывода
                            Console.Write(" ");
                        else if (tab[i, j] > 0 && tab[i, j] / 10 == 0)
                            Console.Write("  ");
                        Console.Write($"{tab[i, j]} ");
                    }
                    Console.WriteLine();
                }

                int min = tab[0, 0];
                for (int i = 0; i < tab.GetLength(0); i++)
                {
                    for (int j = 0; j < tab.GetLength(1); j++)
                    {
                        if (tab[i, j] < min)
                            min = tab[i, j];
                    }
                }

                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine($"Минимальное число в таблице: {min}");
            }
        }
    }
}