﻿int[,] CreateRndMatrix(int rows, int columns, int mn, int mx)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(mn, mx + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5}  |");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ReplaceRowsToColumns(int[,] matrix)
{
    int temp = default;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }

    return matrix;
}

int[,] matrixRnd = CreateRndMatrix(3, 3, -10, 50);
PrintMatrix(matrixRnd);

if (matrixRnd.GetLength(0) == matrixRnd.GetLength(1)) 
{
    int[,] replaceMatrix = ReplaceRowsToColumns(matrixRnd);
    PrintMatrix(matrixRnd);
}
else Console.WriteLine("Вводите массив с равным количеством столбцов и строк");