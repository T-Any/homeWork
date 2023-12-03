// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца


using System;

class Program
{
    static void Main()
    {
        // Массив
        int[,] array = {
            {4, 2, 7},
            {1, 5, 3},
            {8, 6, 9}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Нахожу индексы минимального элемента
        int[] minIndices = FindMinElementIndices(array);

        // Создаю новый массив без строки и столбца с минимальным элементом
        int[,] newArray = RemoveRowAndColumn(array, minIndices[0], minIndices[1]);

        Console.WriteLine("\nМассив после удаления строки и столбца с минимальным элементом:");
        PrintArray(newArray);
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

    // нахожу индексы минимального элемента
    static int[] FindMinElementIndices(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        int minElement = array[0, 0];
        int[] minIndices = { 0, 0 };

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minIndices[0] = i;
                    minIndices[1] = j;
                }
            }
        }

        return minIndices;
    }

    //  удаляю строки и столбца из массива
    static int[,] RemoveRowAndColumn(int[,] array, int rowIndex, int colIndex)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Создаю новый массив с уменьшенными размерами
        int[,] newArray = new int[rows - 1, cols - 1];

        // Копирую элементы, исключая строку и столбец с минимальным элементом
        for (int i = 0, newRow = 0; i < rows; i++)
        {
            // Пропускаю строку с минимальным элементом
            if (i == rowIndex)
                continue;

            for (int j = 0, newCol = 0; j < cols; j++)
            {
                // Пропускаю столбец с минимальным элементом
                if (j == colIndex)
                    continue;

                newArray[newRow, newCol] = array[i, j];
                newCol++;
            }

            newRow++;
        }

        return newArray;
    }
}
