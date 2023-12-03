// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.

using System;

class Program
{
    static void Main()
    {
        // Массив
        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Меняю местами первую и последнюю строки
        SwapRows(array, 0, array.GetLength(0) - 1);

        Console.WriteLine("\nМассив после обмена:");
        PrintArray(array);
    }

    // вывод массива в консоль
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

    // обмен строк
    static void SwapRows(int[,] array, int row1, int row2)
    {
        int cols = array.GetLength(1);

        for (int j = 0; j < cols; j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
}

