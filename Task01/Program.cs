// ** Задача 54.** Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Исходный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Результат:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using static System.Console;
Clear();

WriteLine("Программа, которая упорядочит по убыванию элементы каждой строки двумерного массива.\n");
int size = Convert.ToInt32(ReadLine());
int[,] array = new int[size, size];
WriteLine("Новая матрица:");
FillRandomArray(array, 0, 10);
PrintArray(array);
WriteLine("Отсортированая матрица:");
SortInDescendingOrder(array);

void SortInDescendingOrder(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int r = 0; r < arr.GetLength(1) - 1; r++)
            {

                if (arr[i, r] < arr[i, r + 1])
                {
                    int minValue = arr[i, r];
                    arr[i, r] = arr[i, r + 1];
                    arr[i, r + 1] = minValue;
                }
            }
        }
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Write($"{arr[i, j]} ");
        }
        WriteLine();
    }

}

void FillRandomArray(int[,] arr, int minValue, int maxValue)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue);
        }

    }
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