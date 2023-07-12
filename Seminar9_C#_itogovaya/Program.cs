// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


using System;

class Program
{
    static void Main(string[] args)
    {
        int N = 5;
        PrintNumbers(N);
    }

    static void PrintNumbers(int n)
    {
        if (n >= 1)
        {
            Console.Write(n + " ");
            PrintNumbers(n - 1);
        }
    }
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30 


using System;

class Program
{
    static void Main()
    {
        int M = 1;
        int N = 15;
        int sum = 0;

        // Проходим по всем натуральным числам от M до N
        for (int i = M; i <= N; i++)
        {
            sum += i;
        }

        Console.WriteLine("Сумма натуральных элементов от {0} до {1} равна {2}", M, N, sum);

        // Для второго примера:
        M = 4;
        N = 8;
        sum = 0;

        // Проходим по всем натуральным числам от M до N
        for (int i = M; i <= N; i++)
        {
            sum += i;
        }

        Console.WriteLine("Сумма натуральных элементов от {0} до {1} равна {2}", M, N, sum);
    }
}



//Задача 68*: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main()
    {
        int m = 2;
        int n = 3;
        int result = Ackermann(m, n);
        Console.WriteLine("A({0}, {1}) = {2}", m, n, result);

        m = 3;
        n = 2;
        result = Ackermann(m, n);
        Console.WriteLine("A({0}, {1}) = {2}", m, n, result);
    }
}