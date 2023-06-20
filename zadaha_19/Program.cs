using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите пятизначное число: ");
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number / 10000;
        int secondDigit = (number / 1000) % 10;
        int fourthDigit = (number / 10) % 10;
        int fifthDigit = number % 10;

        bool isPalindrome = (firstDigit == fifthDigit) && (secondDigit == fourthDigit);

        if (isPalindrome) {
            Console.WriteLine($"{number} - палиндром");
        } else {
            Console.WriteLine($"{number} - не палиндром");
        }
    }
}