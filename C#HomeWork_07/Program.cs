
/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] ArrayDoubleNumbers(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble();
            array[i, j] = Math.Round(array[i, j] * 10, 1);
        }
    }
    return array;
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter quantity Rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter quantity Colums: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] Array = ArrayDoubleNumbers(m, n);
ShowArray(Array);

*/



/*
// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указывает, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет
// 1,2 -> 2

int[,] Create2dArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("enter quantity ROWS: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter quantity COLUMS: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] Array = Create2dArray(rows, colums);
ShowArray(Array);

Console.WriteLine("enter the index of the element row: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter the index of the element colum: ");
int j = Convert.ToInt32(Console.ReadLine());

if (i > rows - 1 || j > colums - 1) Console.WriteLine("The element doesn't exist");
else
{
    Console.WriteLine(Array[i, j]);
}

*/



/*
// Задача 52. Задайте двумерный массив из целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2dArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ShowColumsArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"average colum № {j + 1} is {sum / array.GetLength(0)}");
    }
}

Console.WriteLine("enter quantity rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter quantity colums: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] Array = Create2dArray(rows, colums);
ShowArray(Array);
ShowColumsArray(Array);

*/
























