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

int[] ChangeMatrixToArray(int[,] matrix)
{
    int countElems = default;
    int[] array = new int[matrix.Length];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[countElems++] = matrix[i, j];
        }
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write($"{array[array.Length - 1]}.");
}

void FindCountLikeElems(int[] array)
{
    int count = 1;
    int element = array[0];

    Console.WriteLine();
    for (int i = 1; i < array.Length; i++)
    {
        if (element == array[i]) count++;
        else
        {
            Console.WriteLine($"Элементов {element} => {count}");
            element = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Элементов {element} => {count}");
}

int[,] matrixRnd = CreateRndMatrix(3, 3, -10, 50);
PrintMatrix(matrixRnd);

int[] matrixToArray = ChangeMatrixToArray(matrixRnd);
Array.Sort(matrixToArray);
PrintArray(matrixToArray);
FindCountLikeElems(matrixToArray);