double[,] CreateRndMatrixDouble(int rows, int columns, int mn, int mx)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * (mx - mn) + mn), 2);
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 7} |");
        }
        Console.WriteLine();
    }
}

double[,] matrixRnd = CreateRndMatrixDouble(3, 4, -10, 50);
PrintMatrix(matrixRnd);