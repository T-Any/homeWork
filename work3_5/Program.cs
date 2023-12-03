// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

using System;

class Program
{
    static void Main()
    {
        // Массив
        int[,] array = {
            {7, 8, 9},
            {4, 5, 6},
            {3, 13, 2},
            {10, 11, 12}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Нахожу строку с наименьшей суммой элементов
        int minRow = FindRowWithMinSum(array);

        Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minRow + 1}");
    }

    // вывожу массив в консоль
    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // нахожу строки с наименьшей суммой элементов
    static int FindRowWithMinSum(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        int minSum = int.MaxValue;
        int minRow = -1;

        for (int i = 0; i < rows; i++)
        {
            int currentSum = 0;

            for (int j = 0; j < cols; j++)
            {
                currentSum += array[i, j];
            }

            if (currentSum < minSum)
            {
                minSum = currentSum;
                minRow = i;
            }
        }

        return minRow;
    }
}
