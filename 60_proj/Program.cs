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
            Console.Write($"{matrix[i, j],5}  |");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

bool CheckMatricesForMult(int[,] matrix1, int[,] matrix2)
{
    return matrix1.GetLength(1) == matrix2.GetLength(0);
}

int[,] GetMultMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixMultMatrices = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrixMultMatrices[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return matrixMultMatrices;
}

int[,] matrixRnd1 = CreateRndMatrix(2, 1, -1, 1);
int[,] matrixRnd2 = CreateRndMatrix(1, 2, -1, 1);
PrintMatrix(matrixRnd1);
PrintMatrix(matrixRnd2);

if (CheckMatricesForMult(matrixRnd1, matrixRnd2))
{
    int[,] matrixMult = GetMultMatrices(matrixRnd1, matrixRnd2);
    PrintMatrix(matrixMult);
}
else
{
    Console.WriteLine("Не подходящие матрицы");
}