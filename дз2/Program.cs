// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*

int Prog1(int number1)
{
    int num = number1 / 10 % 10;
    return num;
}

Console.Write("Введите трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1;
 
if(num1 < 100 || num1 > 999)
    {
        Console.Write("Вы ввели неверное число");
    }
else
{
    int second = Prog1(num1);
    Console.WriteLine("Вторая цифра вашего числа: " + second);
}


*/
 

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*

int ThirdNum(int number1)
{
    int num = number1 % 10;
    return num;
}


Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1 <= 99 ) 
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while(num1 > 999)
    {
        num1 =  num1 / 10;
    }

    int third = ThirdNum(num1);
    Console.WriteLine("Третья цифра вашего числа: " + third);
}

*/


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


bool Week(int number)
{
    if(number > 5)
    return true;
    else 
    return false;
}

Console.Write("Напишите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 7 || num <1)
{
    Console.WriteLine("Вы ввели неверное число");
}
else
{
    bool weekends = Week(num);
    Console.WriteLine("Этот день недели является выходным: " + weekends);
}

