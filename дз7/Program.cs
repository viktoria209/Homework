// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colemns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 2);

    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
} 

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colemns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
} 

void FindElements(int[,] array, int i, int j)
{
    if(i > array.GetLength(0) || j > array.GetLength(1)) Console.WriteLine("Такого элемента нет");
    else Console.WriteLine(array[i,j]);
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine("Введите позицию строки: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца: ");
int j = Convert.ToInt32(Console.ReadLine());
FindElements(myArray, i, j);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colemns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
} 

double[] ArithmeticMean(int[,] array)
{
    double[] arithMean =new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
            arithMean[j] += array[i, j];
        arithMean[j] = arithMean[j] / array.GetLength(0);
    }
    return arithMean;
}

void ShowArray(double[] array) 
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
double[] result = ArithmeticMean(myArray);
ShowArray(result);
