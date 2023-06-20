using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Таблица кубов чисел от 1 до {0}", n);

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("{0}^3 = {1}", i, Math.Pow(i, 3));
        }

        Console.ReadKey();
    }
}
