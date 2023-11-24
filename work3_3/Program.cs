// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива. 

using System;

class Program
{
    static void Main()
    {
        // Создаем массив из вещественных чисел
        double[] array = new double[] { 3.14, 2.71, 5.55, 1.23, 8.99, 4.44, 6.78, 9.01, 7.33, 10.5 };

        // Выводим массив на экран
        Console.WriteLine("Массив:");
        foreach (double number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Находим максимальный и минимальный элементы массива
        double max = array[0];
        double min = array[0];

        foreach (double number in array)
        {
            if (number > max)
            {
                max = number;
            }

            if (number < min)
            {
                min = number;
            }
        }

        // Находим разницу между максимальным и минимальным элементами
        double difference = max - min;

        // Выводим результат
        Console.WriteLine($"Максимальный элемент: => {max}");
        Console.WriteLine($"Минимальный элемент: => {min}");
        Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");

        // Ждем нажатия клавиши, чтобы консольное окно не закрылось сразу
        Console.ReadKey();
    }
}

 
