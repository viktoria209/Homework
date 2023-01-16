// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*

int Method(int num1, int num2)
{
    int count = 0;
    int result = 1;
    while(count != num2)
    {
        result *= num1;
        count++;
    }
    return result;
}

Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int res = Method(a, b);
Console.WriteLine("First number to the power of second number: " + res);

*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*

int Sum(int num)
{
    int summa = 0;
    while(num > 0)
    {
        int a = num % 10;
        summa += a;
        num = num / 10;
    }
    return summa;
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Sum(number);
Console.WriteLine("The sum of digits in a number: " + result);

*/

//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        Console.Write("Input a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
    }
    return array;
}
void ShowArray(int[] array) 
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int s = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateArray(s);
ShowArray(newArray);