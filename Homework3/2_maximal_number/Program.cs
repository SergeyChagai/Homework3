using System;

namespace _2_maximal_number
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
                for (int number = 0; number < numbers.Length; number++)
                    numbers[number] = Convert.ToInt32(Console.ReadLine());

                //перебор массива
                int rep = numbers[0];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > rep)
                        rep = numbers[i];
                }

                //вывод максимального числа
                Console.WriteLine($"Максимальное число - {rep}");
            }
        }
    }
}
