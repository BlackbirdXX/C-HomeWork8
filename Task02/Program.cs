// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Исходный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Результат:
// 1-строка

using System;
using static System.Console;
Clear();

WriteLine("Программа, которая будет находить строку с наименьшей суммой элементов.");
WriteLine("Задайте размеры двумерного массива через пробел. \nПервое - строка, второе - столбец");

string[] sizes = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizes[0]);
int columns = int.Parse(sizes[1]);
int[,] result = new int[rows, columns];
result = GetRandomArray(rows, columns);
WriteLine("Новый массив");
PrintArray(result);
ComparisonSumRows(result);

void ComparisonSumRows(int[,] arr)
{
    int minSum = SumArrayRows(arr, 0);
    int minRow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (minSum > SumArrayRows(arr, i))
        {
            minSum = SumArrayRows(arr, i);
            minRow = i;
        }
    }
    WriteLine($"Наименьшая сумма в строке № {minRow + 1}.");
}

int SumArrayRows(int[,] arr, int row)
{
    int sumRow = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        sumRow += arr[row, i];
    }
    return sumRow;
}


int[,] GetRandomArray(int row, int column)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}