using System;
using static System.Console;

Clear();

int[][] matrix = new int[][]
{
    new int[] { 1, 4, 7, 2 },
    new int[] { 5, 9, 3, 2 },
    new int[] { 8, 4, 2, 4 }
};

WriteLine("Заданный массив: ");
for (int i = 0; i < 3; i++)
{
    WriteLine(string.Join(" ", matrix[i]));
}

WriteLine("Отсортированный массив: ");
for (int i = 0; i < 3; i++)
{
    Array.Sort(matrix[i]);
    WriteLine(string.Join(" ", matrix[i]));
}
