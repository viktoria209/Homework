// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int Count(int m)
{
    int count = 0;
    for(int i = 0; i < m; i++)
    {
        Console.Write("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a > 0) count++;
    }
    return count;
}

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
int result = Count(m);
Console.Write("Количество чисел больше 0: " + result);
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double FindX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindY(double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return y;
}

Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = FindX(b1, k1, b2, k2);
double y = FindY(k1, b1, x);
Console.WriteLine($"Точка пересечения двух прямых: ({x}, {y})");