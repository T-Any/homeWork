// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

using System;

class Program
{
    static bool IsDivisibleBy7And23(int n)
    {
        return n % 161 == 0;
    }

    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine()!);

        if (IsDivisibleBy7And23(number))
        {
            Console.WriteLine($"{number} кратно одновременно 7 и 23");
        }
        else
        {
            Console.WriteLine($"{number} не кратно одновременно 7 и 23");
        }
    }
}
