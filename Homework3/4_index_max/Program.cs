using System;

namespace _4_index_max
{
    class Program
    {
        static void Main(string[] args)
        {
            //цикл для проверки вводимых значений
            while (true)
            {
                //ввод чисел массива
                int n = 7;
                Console.WriteLine($"Введите {n} чисел");
                int[] numbers = new int[n];

                //перебор массива
                for (int number = 0; number < numbers.Length; number++)
                    numbers[number] = Convert.ToInt32(Console.ReadLine());
                int rep = 0;
                int temp = numbers[0];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > temp)
                    {
                        temp = numbers[i];
                        rep = i;
                    }
                }

                //вывод максимального числа
                Console.WriteLine($"Индекс максимального числа - {rep + 1}");
            }
        }
    }
}
