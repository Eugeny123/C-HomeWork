/*
// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] New2dArray(int rows, int colums)
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

void ShowModifiedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("enter quantity rows:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter quantity colums:  ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] Array = New2dArray(rows, colums);
ShowArray(Array);
Console.WriteLine();
ShowModifiedArray(Array);

*/


/*
// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой 
// элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] New2dArray(int rows, int colums)
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

void SmallValue(int[,] array)
{
    int minrow = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minrow)
        {
            minrow = sum;
            index = i;
        }
        if (i == 0) {
            minrow = sum;
        }
        Console.WriteLine($"string value № {i} = {sum}");
    }
    Console.WriteLine($"row: {index} sum of numbers  {minrow}");
}

Console.WriteLine("enter quantity Rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter quantity Colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] mass = New2dArray(rows, colums);
ShowArray(mass);
SmallValue(mass);

*/




/*
// Задача 62. Напишите программу, которая заполнит 
// спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] New2dArray(int n)
{
    int[,] array = new int[n, n];
    int s = 1;

    for (int k = 0; k < n / 2; k++)
    {
        for (int i = k; i < n - k - 1; i++)
        {
            array[k, i] = s;
            s++;
        }
        for (int i = k; i < n - k - 1; i++)
        {
            array[i, n - k - 1] = s;
            s++;
        }
        for (int i = n - k - 1; i > k; i--)
        {
            array[n - k - 1, i] = s;
            s++;
        }
        for (int i = n - k - 1; i > k; i--)
        {
            array[i, k] = s;
            s++;
        }
    }
    if (n % 2 != 0) array[n / 2, n / 2] = n * n;
    return array;
}



void WriteArray(int[,] array)
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


Console.WriteLine("enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Array = New2dArray(n);
WriteArray(Array);

*/












