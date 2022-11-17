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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}

int CalcSummDiagonal(int[,] matrix)
{
    int sum = default;
    int diag = default;

    if (matrix.GetLength(0) > matrix.GetLength(1))
        diag = matrix.GetLength(1);
    else
        diag = matrix.GetLength(0);

    for (int i = 0; i < diag; i++)
    {
        sum += matrix[i, i];
    }
    
    return sum;
}

int[,] matrixRnd = CreateRndMatrix(3, 4, -10, 50);
PrintMatrix(matrixRnd);
Console.WriteLine();
int sumDiag = CalcSummDiagonal(matrixRnd);
Console.WriteLine($"Сумма элементов главной диагонали {sumDiag}");