using System;
using static System.Console;

Clear();

int X = 2;
int Y = 2;
int Z = 2;
int[,,] result = new int[X, Y, Z];
List<int> numbers = new List<int> { 12, 22, 31, 45, 53, 64, 78, 82 };

WriteLine("Заданный массив: ");
for (int i = 0; i < X; i++)
{
    for (int j = 0; j < Y; j++)
    {
        for (int k = 0; k < Z; k++)
        {
            
            result[i, j, k] = numbers[0];
            numbers.RemoveAt(0);
            Write($"{result[i, j, k]}({i},{j},{k}) ");
        }
        WriteLine();
    }
    WriteLine();
}
