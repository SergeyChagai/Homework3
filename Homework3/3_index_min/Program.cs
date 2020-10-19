using System;

namespace _3_index_min
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
                for (int number = 0; number < numbers.Length; number++)
                    numbers[number] = Convert.ToInt32(Console.ReadLine());

                //перебор массива
                int rep = 0;
                int temp = numbers[0];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < temp)
                    {
                        temp = numbers[i];
                        rep = i;
                    }
                }

                //вывод минимального числа
                Console.WriteLine($"Индекс минимального числа - {rep + 1}"); //можно и без добавления единицы, но пользователь не поймет
            }
        }
    }
}
