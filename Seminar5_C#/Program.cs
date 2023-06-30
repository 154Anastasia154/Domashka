// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using System;

class Program
{
    static void Main()
    {
        int[] numbers = GenerateRandomArray(4); // Замените 4 на нужный вам размер массива

        Console.WriteLine("Исходный массив: " + string.Join(", ", numbers));

        int count = CountEvenNumbers(numbers);

        Console.WriteLine("Количество чётных чисел: " + count);
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        return array;
    }

    static int CountEvenNumbers(int[] array)
    {
        int count = 0;

        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;

class Program
{
    static void Main()
    {
        int[] array = { 3, 7, 23, 12 }; // Исходный массив

        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }

        Console.WriteLine("Сумма элементов на нечётных позициях: " + sum);
        Console.ReadLine();
    }
}



// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] array = { 3.22, 4.2, 1.15, 77.15, 65.2 }; // Исходный массив

        double difference = GetMaxValue(array) - GetMinValue(array);

        Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
        Console.ReadLine();
    }

    static double GetMaxValue(double[] array)
    {
        return array.Max();
    }

    static double GetMinValue(double[] array)
    {
        return array.Min();
    }
}
