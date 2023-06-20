using System;

class Program
{
    static void Main(string[] args)
    {
        // Пример координат двух точек
        double x1 = 0, y1 = 0, z1 = 0; // Координаты первой точки
        double x2 = 1, y2 = 1, z2 = 1; // Координаты второй точки

        // Вычисление расстояния между точками
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        // Вывод результата на консоль
        Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {distance}");
    }
}