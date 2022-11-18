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
        for (int j = 0; j < matrix.GetLength(1); j++)                 // метод только для проверки работоспособности
        {
            Console.Write($"{matrix[i, j],5}  |");
        }
        Console.WriteLine();
    }
}

void FindElementMatrix(int[,] matrix)
{
    Console.WriteLine("Введите индексы искомого числа в массиве");
    int row = Convert.ToInt32(Console.ReadLine());                   // решил оставить внутри метода ввод данных от пользователя
    int column = Convert.ToInt32(Console.ReadLine());

    if (row > matrix.GetLength(0) - 1 ||
        column > matrix.GetLength(1) - 1 ||
        row < 0 || column < 0) Console.WriteLine("Такого элемента нет в массиве");
    else Console.WriteLine($"Число из массива с индексами [{row}, {column}] равно => {matrix[row, column]}");
}

int[,] matrixRnd = CreateRndMatrix(3, 4, -10, 50);
PrintMatrix(matrixRnd);
FindElementMatrix(matrixRnd);