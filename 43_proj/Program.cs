int[] FibonacciN(int num)
{
    int[] arrayFibonacci = new int[num];
    arrayFibonacci[1] = 1;
    for (int i = 2; i < num; i++)
    {
        arrayFibonacci[i] = arrayFibonacci[i - 1] + arrayFibonacci[i - 2];
    }
    return arrayFibonacci;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Введите количество чисел Фибоначчи");
int number = Convert.ToInt32(Console.ReadLine());

int[] fibonacciArray = FibonacciN(number);
PrintArray(fibonacciArray);