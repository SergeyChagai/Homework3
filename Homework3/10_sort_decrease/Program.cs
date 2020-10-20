using System;

namespace _10_sort_decrease
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
                int temp;

                //перебор массива вставкой
                for (int i = 1; i < numbers.Length; i++)
                    for (int j = i; j > 0 && numbers[j - 1] < numbers[j]; j--)
                    {
                        temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;
                    }

                //вывод результата
                foreach (int num in numbers)
                    Console.Write($"{num} ");
                Console.WriteLine();
            }
        }
    }
}
/*  Можно использовать Random
 *  
 *  int a[] = new int[n]
 *  
 *  Random r = new Random()
 *  
 *  for (int i = 0; i < a.Length; i++)
 *  {
 *      a[i] = r.Next(-100, 100);
 *      Console.WriteLine(a[i] + " ");
 *  }
 *  
 *  
 *  
 */