// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд 
// числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

using System;

class Program
{
    static void Main()
    {
        // Вводим натуральное число в диапазоне от 1 до 100000
        Console.Write("Введите натуральное число (от 1 до 100000): ");
        int number = int.Parse(Console.ReadLine() !);

        // Проверяем, что число находится в указанном диапазоне
        if (number < 1 || number > 100000)
        {
            Console.WriteLine("Число введено некорректно. Пожалуйста, введите число от 1 до 100000.");
            return;
        }

        // Создаем массив из цифр числа
        int numDigits = (int)Math.Floor(Math.Log10(number) + 1); // Количество цифр в числе
        int[] digitArray = new int[numDigits];

        for (int i = numDigits - 1; i >= 0; i--)
        {
            digitArray[i] = number % 10;
            number /= 10;
        }

        // Выводим массив на экран
        Console.WriteLine("Массив из цифр числа: => ");
        foreach (int digit in digitArray)
        {
            Console.Write(digit + " ");
        }

        // Ждем нажатия клавиши, чтобы консольное окно не закрылось сразу
        Console.ReadKey();
    }
}
