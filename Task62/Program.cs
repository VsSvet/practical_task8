using System;
using static System.Console;

Clear();
int size = 4;
int[,] matrix = new int[4, 4];
int val = 1;

for (int i = 0; i < size; i++)
{
    for (int j = i; j < size - i; j++)
    {
        matrix[i, j] = val;
        val++;
    }

    for (int j = i + 1; j < size - i; j++)
    {
        matrix[j, size - 1 - i] = val;
        val++;
    }

    for (int j = size - 2 - i; j > i - 1; j -= 1)
    {
        matrix[size - 1 - i, j] = val;
        val++;
    }

    for (int j = size - 2 - i; j > i; j -= 1)
    {
        matrix[j, i] = val;
        val++;
    }
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Write($"{matrix[i, j]} ");
    }
    WriteLine();
}
