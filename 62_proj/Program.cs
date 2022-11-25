// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiralMatrix(int rows, int columns, int mn, int mx)
{
    int[,] matrix = new int[rows, columns];

    for (int k = 1; k < matrix.Length; k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = k++;
            }
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
            Console.Write($"{matrix[i, j],5}  |");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] matrixSpiral = CreateSpiralMatrix(4, 4, 1, 16);
PrintMatrix(matrixSpiral);