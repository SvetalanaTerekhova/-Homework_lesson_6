// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Первая прямая задана уравнением y = k1 * x + b1.");
Console.Write("Задайте значение k1 в уравнении: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Задайте значение b1 в уравнении: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Вторая прямая задана уравнением y = k2 * x + b2 ");
Console.Write("Задайте значение k2 в уравнении: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Задайте значение b2 в уравнении: ");
double b2 = double.Parse(Console.ReadLine());

double x = (b1 - b2) / (k2 - k1);
double y = k1 * x + b1;

Console.WriteLine($"Ответ: координаты точки пересечения двух прямых ({x},{y})");