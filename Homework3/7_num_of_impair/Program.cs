using System;

namespace _7_num_of_impair
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //ввод чисел массива
                int n = 5;
                Console.WriteLine($"Введите {n} чисел");
                int[] numbers = new int[n];
                for (int number = 0; number < numbers.Length; number++)
                    numbers[number] = Convert.ToInt32(Console.ReadLine());
                int rep = 0;

                //перебор массива
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0)
                        rep++;
                }
                //вывод результата
                    Console.WriteLine($"Количество нечетных цифр - {rep}");
            }
        }
    }
}
