using System;

namespace _5_sum_imp_index
{
    class Program
    {
        static void Main(string[] args)
        {
            //цикл для проверки вводимых значений
            while (true)
            {
                //ввод чисел массива
                int n = 4;
                Console.WriteLine($"Введите {n} чисел");
                int[] numbers = new int[n];
                for (int number = 0; number < numbers.Length; number++)
                    numbers[number] = Convert.ToInt32(Console.ReadLine());

                //перебор массива
                int rep = 0;
                for (int i = 0; i < numbers.Length; i += 2)
                    rep += numbers[i];

                //вывод результата
                Console.WriteLine($"Сумма элементов массива с нечетными индексами - {rep}");
            }
        }
    }
}
