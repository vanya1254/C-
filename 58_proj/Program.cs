int[,] CreateRndMatrix(int rows, int columns, int mn, int mx)
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

void SortMatrixRowsToMin(int[,] matrix)
{
    int min = default;

    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    min = matrix[i, j];

                    if (min < matrix[i, j + 1])
                    {
                        matrix[i, j] = matrix[i, j + 1];
                        matrix[i, j + 1] = min;
                    }
                }
            }
        }
    }
}

int[,] matrixRnd = CreateRndMatrix(4, 5, -10, 50);
PrintMatrix(matrixRnd);

SortMatrixRowsToMin(matrixRnd);
PrintMatrix(matrixRnd);