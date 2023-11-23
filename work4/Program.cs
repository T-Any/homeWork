// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine() !);

        Console.Write("Цифры числа {0} через запятую: ", number);
        while (number > 0)
        {
            Console.Write("{0}, ", number % 10);
            number /= 10;
        }
    }
}

