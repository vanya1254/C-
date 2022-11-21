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

int[] FindMinElem(int[,] matrix, int minElemLast)
{
    int[] indexMinElem = new int[2] {0, 0};

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (minElemLast > matrix[i, j])
            {
                indexMinElem = new int[2] {i, j};
                minElemLast = matrix[i, j];
            }
        }
    }

    return indexMinElem;
}

int[,] CreateMatrixWithoutMinElemRowsColumn(int[,] matrix, int[] indexMinElem)
{
    int[,] matrixWithoutMin = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int countRow = default;
    int countColumn = default;

    for (int i = 0; i < matrixWithoutMin.GetLength(0); i++)
    {
        if (countRow == indexMinElem[0]) countRow++;

        for (int j = 0; j < matrixWithoutMin.GetLength(1); j++)
        {
            if (countColumn == indexMinElem[1]) countColumn++;
            {
                matrixWithoutMin[i, j] = matrix[countRow, countColumn];
            }
            countColumn++;
        }
        countColumn = 0;
        countRow++;
    }

    return matrixWithoutMin;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[,] matrixRnd = CreateRndMatrix(3, 3, -10, 50);
PrintMatrix(matrixRnd);

int[] indexMinElemLast = FindMinElem(matrixRnd, 50);
PrintArray(indexMinElemLast);
Console.WriteLine();
int[,] matrixWithoutMinElemRowsColumn = CreateMatrixWithoutMinElemRowsColumn(matrixRnd, indexMinElemLast);
PrintMatrix(matrixWithoutMinElemRowsColumn);