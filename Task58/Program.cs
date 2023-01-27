using System;
using static System.Console;

Clear();

int[][] matrix1 = new int[][]
{
    new int[] { 1, 4, 7, 2 },
    new int[] { 5, 9, 3, 2 },
    new int[] { 8, 4, 2, 4 },
    new int[] { 5, 2, 6, 7 }
};

int[][] matrix2 = new int[][]
{
    new int[] { 1, 5, 8, 5 }, 
    new int[] { 4, 9, 4, 2 },
    new int[] { 7, 2, 2, 6 },
    new int[] { 2, 3, 4, 7 }
};

WriteLine("Произведение двух матриц: ");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Write($"{matrix1[i][j]*matrix2[i][j]} ");
    }
    WriteLine();
}





