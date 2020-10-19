using System;

namespace _1_minimal_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //цикл для проверки вводимых значений
            while (true)
            {
                //ввод чисел массива
                Console.WriteLine("Введите 4 числа");
                int[] numbers = new int[4];

                //перебор массива
                for (int number = 0; number < numbers.Length; number++)
                    numbers[number] = Convert.ToInt32(Console.ReadLine());
                int temp = numbers[0];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < temp)
                        temp = numbers[i];
                }

                //вывод минимального числа
                Console.WriteLine($"Минимальное число - {temp}");
            }
        }
    }
}
