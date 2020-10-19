using System;

namespace _6_Reverse
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

                //перебор массива
                for (int i = 0; i < numbers.Length / 2; i++)
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[numbers.Length - i - 1];
                    numbers[numbers.Length - i - 1] = temp;
                }
                //вывод результата
                foreach (int num in numbers)
                    Console.WriteLine($"{num} ");
            }
        }
    }
}
