using System;

namespace _9_sort
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
                for (int i = 0; i < numbers.Length; i++)
                {
                    int temp;
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (numbers[i] >= numbers[j])
                            continue;
                        else
                        {
                            temp = numbers[i];
                            numbers[i] = numbers[j];
                            numbers[j] = temp;
                        }
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
