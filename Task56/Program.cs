using System;
using static System.Console;

Clear();

int[][] matrix = new int[][]
{
    new int[] { 1, 4, 7, 2 },
    new int[] { 5, 9, 3, 2 },
    new int[] { 8, 4, 2, 4 },
    new int[] { 5, 2, 6, 7 }
};

int numberRow = 0;
int smallestSum = matrix[1].Sum();

for (int i = 0; i < 4; i++)
{
    if(matrix[i].Sum() < smallestSum)
    {
        smallestSum = matrix[i].Sum();
        numberRow = i+1;
    }
}

WriteLine($"{numberRow} строка с наименьшей суммой");