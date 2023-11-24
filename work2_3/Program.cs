// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 10 целых чисел
        int[] array = new int[] { 5, 12, 8, 3, 17, 22, 14, 9, 6, 11 };

        // Выводим массив на экран
        Console.WriteLine("Массив:");
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Находим количество чётных чисел в массиве
        int evenCount = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        // Выводим результат
        Console.WriteLine($"Количество чётных чисел в массиве: => {evenCount}");

        // Ждем нажатия клавиши, чтобы консольное окно не закрылось сразу
        Console.ReadKey();
    }
}

