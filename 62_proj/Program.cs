// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiralMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int number = 1;

    for (int i = 0; i < matrix.Length / 2; i++)
    {
        for (int j = i; j < matrix.Length - i; j++) matrix[i, j] = number++;
        for (int k = i + 1; k < matrix.Length - i; k++) matrix[k, matrix.Length - 1 - i] = number++;
        for (int j = matrix.Length - i - 2; j >= i; j--) matrix[matrix.Length - 1 - i, j] = number++;
        for (int k = matrix.Length - 2 - i; k > i; k--) matrix[k, i] = number++;
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

int[,] matrixSpiral = CreateSpiralMatrix(5, 5);
PrintMatrix(matrixSpiral);