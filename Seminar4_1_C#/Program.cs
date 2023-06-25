/*
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System;

class Program {
  static void Main(string[] args) {
    int A = 3;
    int B = 5;
    Console.WriteLine(Power(A, B)); // Output: 243

    A = 2;
    B = 4;
    Console.WriteLine(Power(A, B)); // Output: 16
  }

  static int Power(int baseNum, int powerNum) {
    int result = 1;
    for (int i = 0; i < powerNum; i++) {
      result *= baseNum;
    }
    return result;
  }
}



/*


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;

class Program {
  static int GetSumOfDigits(int num) {
    int sum = 0;
    while (num != 0) {
      sum += num % 10;
      num /= 10;
    }
    return sum;
  }

  static void Main(string[] args) {
    int num = 452;
    int sum = GetSumOfDigits(num);
    Console.WriteLine($"Сумма цифр числа {num} равна {sum}");

    num = 82;
    sum = GetSumOfDigits(num);
    Console.WriteLine($"Сумма цифр числа {num} равна {sum}");

    num = 9012;
    sum = GetSumOfDigits(num);
    Console.WriteLine($"Сумма цифр числа {num} равна {sum}");
  }
}