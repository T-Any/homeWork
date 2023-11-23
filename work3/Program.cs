// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number / 10;
        int secondDigit = number % 10;

        if (firstDigit > secondDigit)
        {
            Console.WriteLine($"Наибольшая цифра числа {number} - {firstDigit}");
        }
        else
        {
            Console.WriteLine($"Наибольшая цифра числа {number} - {secondDigit}");
        }
    }
}

