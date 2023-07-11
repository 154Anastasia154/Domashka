// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2


using System;

class Program
{
    static void Main()
    {
        // Исходный массив
        int[,] array = new int[,]
        {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        // Упорядочиваем строки массива по убыванию
        SortRowsDescending(array);

        // Выводим упорядоченный массив
        Console.WriteLine("Упорядоченный массив:");
        PrintArray(array);
    }

    static void SortRowsDescending(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            // Сортируем текущую строку по убыванию
            for (int j = 0; j < cols - 1; j++)
            {
                for (int k = j + 1; k < cols; k++)
                {
                    if (array[i, k] > array[i, j])
                    {
                        int temp = array[i, k];
                        array[i, k] = array[i, j];
                        array[i, j] = temp;
                    }
                }
            }
        }
    }

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
}



//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[,]
        {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

        int minRowSum = int.MaxValue;
        int minRowIndex = -1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minRowSum)
            {
                minRowSum = rowSum;
                minRowIndex = i;
            }
        }

        Console.WriteLine("Строка с наименьшей суммой элементов:");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[minRowIndex, j] + " ");
        }

        Console.ReadLine();
    }
}



//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

using System;

class Program
{
    static void Main()
    {
        int[,] matrix1 = { { 2, 4 }, { 3, 2 } };
        int[,] matrix2 = { { 3, 4 }, { 3, 3 } };

        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != matrix2.GetLength(0))
        {
            Console.WriteLine("Умножение матриц невозможно!");
            return;
        }

        int[,] resultMatrix = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }

        Console.WriteLine("Результат умножения матриц:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

using System;

class Program
{
    static void Main()
    {
        int[,,] array3D = new int[2, 2, 2];
        int num = 10;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    array3D[i, j, k] = num++;
                }
            }
        }

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.WriteLine($"{array3D[i, j, k]} ({i},{j},{k})");
                }
            }
        }
    }
}


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

using System;

class Program
{
    static void Main()
    {
        int n = 4;
        int[,] array = new int[n, n];

        int value = 1;
        int minRow = 0, maxRow = n - 1, minCol = 0, maxCol = n - 1;

        while (value <= n * n)
        {
            for (int i = minCol; i <= maxCol; i++)
                array[minRow, i] = value++;

            for (int i = minRow + 1; i <= maxRow; i++)
                array[i, maxCol] = value++;

            for (int i = maxCol - 1; i >= minCol; i--)
                array[maxRow, i] = value++;

            for (int i = maxRow - 1; i > minRow; i--)
                array[i, minCol] = value++;

            minRow++;
            maxRow--;
            minCol++;
            maxCol--;
        }

        // Вывод массива на консоль
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0:D2} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }
}

