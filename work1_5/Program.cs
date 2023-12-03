// Задача 1: Напишите программу, которая на вход
//принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание,
//что такого элемента нет.

using System;

class Program
{
    static void Main()
    {
               int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // размеры массива
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Запрашиваю позиции элемента
        Console.Write("Введите номер строки: ");
        int rowIndex = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int colIndex = int.Parse(Console.ReadLine());

        // Проверяю, находятся ли введенные индексы в пределах массива
        if (rowIndex >= 0 && rowIndex < rows && colIndex >= 0 && colIndex < cols)
        {
            // Получаю значение элемента по введенным индексам
            int elementValue = array[rowIndex, colIndex];
            Console.WriteLine($"Значение элемента в позиции [{rowIndex}, {colIndex}]: {elementValue}");
        }
        else
        {
            Console.WriteLine("Элемента с указанными индексами не существует в массиве.");
        }
    }
}
