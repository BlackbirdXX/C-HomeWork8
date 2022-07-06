// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Массив A:
// 6 0 2
// 0 4 8
// 0 7 9
// Массив В:
// 0 0 3
// 5 0 4
// 8 2 0
// Результат
// 16 4 18
// 84 16 16
// 107 18 28

using System;
using static System.Console;
Clear();

WriteLine("Программа, которая будет находить произведение двух матриц.");
WriteLine("Задайте размеры двумерных массивов через пробел. \nПервое - строка, второе - столбец");

string[] sizes = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizes[0]);
int columns = int.Parse(sizes[1]);
int[,] arrayA = GetRandomArray(rows, columns);
int[,] arrayB = GetRandomArray(rows, columns);
WriteLine("Массив А");
PrintArray(arrayA);
WriteLine("Массив B");
PrintArray(arrayB);
WriteLine("Произведение массивов равно:");
MultiplyArrays(arrayA, arrayB);

void MultiplyArrays(int[,] arrayA, int[,] arrayB)
{
    int[,] multiply = new int[arrayA.GetLength(0), arrayA.GetLength(1)];
    for (int i = 0; i < multiply.GetLength(0); i++)
    {
        for (int j = 0; j < multiply.GetLength(1); j++)
        {
            int sumElemet = 0;
            for (int r = 0; r < multiply.GetLength(1); r++)
            {
                sumElemet += arrayA[i, r] * arrayB[r, j];
            }
            multiply[i, j] = sumElemet;
        }

    }
    PrintArray(multiply);

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

int[,] GetRandomArray(int row, int column)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 4);
        }
    }
    return result;
}
