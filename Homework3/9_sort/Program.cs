﻿using System;

namespace _9_sort_increase
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите количество элементов массива:");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] numbers = new int[n]; //создаем массив типа int[] с количеством элементов равным n
                Random r = new Random();    //создаем новую переменную класса Random
                
                for (int i = 0; i < numbers.Length; i++)    //заполняем массив | numbers.Length - длина массива (то же самое, что и n, в данном случае)
                {
                    numbers[i] = r.Next(-100, 100);         //r.Next() выдает рандомное число типа int | аргументы (то, что в скобках - диапазон,
                    Console.Write(numbers[i] + ", ");       //из которого будут выбираться рандомные числа) | вывод полученного массива в консоль
                }

                //перебор массива выбором
                for (int i = 0; i < numbers.Length; i++)        //внешний цикл дает указание двигаться вправо, когда предыдущий элемент встал на свое место
                {
                    int max = i;                                //в переменную max сохраняем индекс (указание, какой по счету это элемент в массиве) максимального числа, пока что это будет i, то есть число, на котором остановился в данный момент внешний цикл
                    for (int j = i; j < numbers.Length; j++)    //внутренний массив ищет максимальное число из еще неотсортированных чисел (поэтому сначала j = i, т.к. это первое неотсортированное число)
                    {
                        if (numbers[j] > numbers[max])          //если выполняется, что какое-то число больше, чем то, которое сейчас записано как максимальное, записываем индекс этого числа
                            max = j;
                    }
                    int temp = numbers[i];                      //после того, как нашли максимальное число из неотсортированных, меняем местами это максимальное число и то,
                    numbers[i] = numbers[max];                  //что было в начале неотсортированного участка, после чего наш массив становится на 1 элемент более упорядоченным
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
