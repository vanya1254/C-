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

int[,] ReplaceFirstEndRows(int[,] matrix)
{
    int temp = default;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }

    return matrix;
}

int[,] matrixRnd = CreateRndMatrix(3, 4, -10, 50);
PrintMatrix(matrixRnd);
Console.WriteLine();
int[,] replaceMatrix = ReplaceFirstEndRows(matrixRnd);
PrintMatrix(matrixRnd);