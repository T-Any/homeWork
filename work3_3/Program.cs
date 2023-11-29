// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива. 

using System;

class Program
{
    static void Main()
    {
        // Создаю массив из вещественных чисел
        double[] array = new double[] { 3.14, 2.71, 5.55, 1.23, 8.99, 4.44, 6.78, 9.01, 7.33, 10.5 };

        // Вывожу массив на экран
        Console.WriteLine("Массив:");
        foreach (double number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Нахожу максимальный и минимальный элементы массива
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

        // Нахожу разницу между максимальным и минимальным элементами
        double difference = max - min;

        // Вывожу результат
        Console.WriteLine($"Максимальный элемент: => {max}");
        Console.WriteLine($"Минимальный элемент: => {min}");
        Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");

       
        Console.ReadKey();
    }
}

 
