using System;

namespace _9_sort_increase
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
                //Console.WriteLine($"Введите {n} чисел:");
                int[] numbers = new int[n];
                //for (int number = 0; number < numbers.Length; number++)
                //    numbers[number] = Convert.ToInt32(Console.ReadLine());
                Random r = new Random();
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = r.Next(-100, 100);
                    Console.Write(numbers[i] + ", ");
                }

                //перебор массива выбором
                for (int i = 0; i < numbers.Length; i++)
                {
                    int max = i;
                    for (int j = i; j < numbers.Length; j++)
                    {
                        if (numbers[j] > numbers[max])
                            max = j;
                    }
                    int temp = numbers[i];
                    numbers[i] = numbers[max];
                    numbers[max] = temp;
                }

                //вывод результата

                Console.WriteLine();
                Console.WriteLine("---------------------------------------");
                foreach (int num in numbers)
                    Console.Write($"{num}, ");
                Console.WriteLine();
            }
        }
    }
}
