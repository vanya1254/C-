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

int[] FindSumElemRows(int[,] matrix)
{
    int[] sumRowsArray = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRowsArray[i] += matrix[i, j];
        }
    }

    return sumRowsArray;
}

int FindIndexMinElemArray(int[] array)
{
    int min = array[0];
    int indexMin = 0;
    
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            indexMin = i;
        }
    }

    return indexMin;
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

int[,] matrixRnd = CreateRndMatrix(4, 4, -10, 50);
PrintMatrix(matrixRnd);

int[] arraySumRows = FindSumElemRows(matrixRnd);                    // массив сумм строк
PrintArray(arraySumRows);
Console.WriteLine();
int indexMinSumRow = FindIndexMinElemArray(arraySumRows);
Console.WriteLine($"Минимальная сумма в строке = > {indexMinSumRow + 1}");