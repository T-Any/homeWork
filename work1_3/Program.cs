// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 10 целых чисел
        int[] array = new int[10];

        // Заполняем массив случайными целыми числами от 1 до 100
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
        }

        // Выводим массив на экран
        Console.WriteLine("Массив:");
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Находим количество элементов в отрезке [20, 90]
        int count = 0;
        foreach (int number in array)
        {
            if (number >= 20 && number <= 90)
            {
                count++;
            }
        }

       
        Console.WriteLine($"Количество элементов в отрезке [20, 90]: => {count}");

        
                Console.ReadKey();
    }
}
