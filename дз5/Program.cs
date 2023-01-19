// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size) 
{
    int[] array = new int [size]; 
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

void ShowArray(int[] array)  
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int Even(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++) 
        if (array[i] % 2 == 0) count++;
    return count;
}


Console.Write("Input a length of array: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(len);
ShowArray(newArray);
int result = Even(newArray);
Console.WriteLine("Количество четных чисел в массиве: " + result);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreateRandomArray(int size, int minVal, int maxVal) 
{
    int[] array = new int [size]; 
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minVal, maxVal + 1);
    return array;
}

void ShowArray(int[] array)  
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int Sum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(i % 2 != 0) sum += array[i];
    return sum;
}


Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min posseble value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posseble value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);
int result = Sum(newArray);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + result);
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



double[] CreateRandomArray(int size, int minVal, int maxVal) 
{
    double[] array = new double [size]; 
    for(int i = 0; i < size; i++)
        array[i] = Math.Round(new Random().Next(minVal, maxVal) + new Random().NextDouble(), 2);
    return array;
}

void ShowArray(double[] array)  
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double Difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    double diff = 0;
    for(int i = 0; i < array.Length; i++)
        if(min > array[i]) min = array[i];
    for(int i = 0; i < array.Length; i++)
        if(max < array[i]) max = array[i];
    diff = max - min;
    return diff;
}

Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min posseble value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max posseble value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);
double result = Difference(newArray);
Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + result);

