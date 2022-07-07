// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(0,1,0) 53(0,1,1)
// 32(1,0,0) 41(1,0,1)
// 66(1,1,0) 88(1,1,1)

using System;
using static System.Console;
Clear();

WriteLine("Программа, которая построчно выводит массив, добавляя индексы каждого элемента.\nМассив задан 2х2х2.");

int[,,] array3D = new int[2, 2, 2];
//Print3DArray(FillRandom3DArray(array3D));
FillRandom3DArray(array3D);
Print3DArray(array3D);
RefillArray(array3D);
Print3DArray(array3D);

void RefillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int r = 0; r < array.GetLength(2); r++)
            {
                int temp = 0;
                while (temp == array[i, j, r])
                {
                    array[i, j, r] = new Random().Next(0, 15);
                    temp = array[i, j, r];
                }
            }
        }
    }
}
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        WriteLine($"Слой №{i}");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int r = 0; r < array.GetLength(2); r++)
                Write($"{array[i, j, r]}({i},{j},{r}) ");
            WriteLine();
        }
        WriteLine();
    }
}

void FillRandom3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int r = 0; r < array.GetLength(2); r++)
            {
                array[i, j, r] = new Random().Next(10, 100);
            }
        }
    }
}
