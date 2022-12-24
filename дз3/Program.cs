// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*

int Chislo(int number)
{
    int num2 = 0;
    while(number > 0)
    {
        int digit = number % 10;
        number = number / 10;
        num2 = num2 * 10 + digit;
    }
    return num2;
}

bool Palindrome(int number1, int number2)
{ 
   if(number1 == number2)
   return true;
   else
   {
    return false;
   }
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int inverted = Chislo(num);
bool result = Palindrome(num, inverted);
Console.WriteLine("The number is a palindrome: " + result);

*/


//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*

double Distance(double x1, double y1,double z1, double x2, double y2, double z2)
{
    double xyz = 0;
    xyz = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return xyz;
}

Console.Write("Input the coordinates of the first point: ");
double pointX1 = Convert.ToDouble(Console.ReadLine());
double pointY1 = Convert.ToDouble(Console.ReadLine());
double pointZ1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinates of the secont point: ");
double pointX2 = Convert.ToDouble(Console.ReadLine());
double pointY2 = Convert.ToDouble(Console.ReadLine());
double pointZ2 = Convert.ToDouble(Console.ReadLine());
double dis = Distance(pointX1, pointY1, pointZ1, pointX2, pointY2, pointZ2);
Console.WriteLine("Distance between points: " + dis);

*/


//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.



void Cube(int num)
{
    double cub = 1;
    while(cub <= num)
    {
        Console.Write(Math.Pow(cub, 3) + " ");
        cub++;
    }
}

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Кубы чисел: ");
Cube(num1);





