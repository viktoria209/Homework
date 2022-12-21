// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    Console.WriteLine(number1 + " is more than " + number2);
}
else if(number1 < number2)
{
    Console.WriteLine(number2 + " is more than " + number1);
}
else 
{
    Console.WriteLine(number1 + " equals " + number2);
}
*/




//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max=number1;

if(max < number2)
{
    max = number2;
}
if(max < number3)
{
    max = number3;
}
Console.WriteLine(max);
*/




//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}
*/




//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;
while(current <= number)
{
    if(current % 2 == 0)
    {
      Console.WriteLine(current + " ");
    }
    current = current + 1;
}
