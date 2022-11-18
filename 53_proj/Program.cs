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

double[] FindArithmeticMeanColumns(int[,] matrix)
{
    double[] arithmeticMeanArray = new double[matrix.GetLength(1)];
    double arithmeticMeanColumn = default; 

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arithmeticMeanColumn += matrix[i, j];
        }
        arithmeticMeanArray[j] = Math.Round(arithmeticMeanColumn / matrix.GetLength(0), 2);
        arithmeticMeanColumn = 0;
    }

    return arithmeticMeanArray;
}

void PrintArray(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write($"{array[array.Length - 1]}.");
}

int[,] matrixRnd = CreateRndMatrix(3, 4, -10, 50);
PrintMatrix(matrixRnd);

double[] arrayArithmeticMean = FindArithmeticMeanColumns(matrixRnd);
PrintArray(arrayArithmeticMean);
Console.WriteLine();