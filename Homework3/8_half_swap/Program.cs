using System;

namespace _8_half_swap
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //ввод чисел массива
                Console.WriteLine("Введите количество элементов массива:");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Введите {n} чисел:");
                int[] numbers = new int[n];
                for (int number = 0; number < numbers.Length; number++)
                    numbers[number] = Convert.ToInt32(Console.ReadLine());

                //перебор массива
                for (int i = 0; i < numbers.Length / 2; i++)
                {
                    int temp = numbers[i];
                    if (numbers.Length % 2 == 0)
                    {
                        numbers[i] = numbers[numbers.Length / 2 + i];
                        numbers[numbers.Length / 2 + i] = temp;
                    }
                    else
                    {
                        numbers[i] = numbers[numbers.Length / 2 + i + 1];
                        numbers[numbers.Length / 2 + i + 1] = temp;
                    }
                }

                //вывод результата
                foreach (int num in numbers)
                    Console.Write($"{num} ");
                Console.WriteLine();
            }
        }
    }
}
