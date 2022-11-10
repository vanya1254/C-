int[] RndMass(int size, int mn, int mx)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(mn, mx + 1);        
    }

    return array;
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

int[] SumNumsPosNeg(int[] array)
{
    int sumPos = 0;
    int sumNeg = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPos += array[i];
        else sumNeg += array[i]; 
    }

    return new int[]{sumPos, sumNeg};
}

int[] arr = RndMass(12, -9, 9);
int[] sumNumsPosNeg = SumNumsPosNeg(arr);

PrintArray(arr);
Console.WriteLine($"Сумма положительных элементов = {sumNumsPosNeg[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {sumNumsPosNeg[1]}");