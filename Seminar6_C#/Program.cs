// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите числа через запятую:");
        string input = Console.ReadLine();

        // Разделяем введенные числа по запятой
        string[] numbers = input.Split(',');

        int count = 0;

        // Перебираем все введенные числа и считаем количество чисел, больших нуля
        foreach (string number in numbers)
        {
            int value;
            if (int.TryParse(number.Trim(), out value) && value > 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество чисел, больших нуля: {count}");
    }
}