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

int GetSummatorElem(int[] array)
{
    int summator = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i != 0 && i % 2 != 0) summator += array[i];
    }

    return summator;
}

int[] arr = RndMass(5, -100, 101);
PrintArray(arr);
int sum = GetSummatorElem(arr);
Console.WriteLine($"Сумма элементов на нечетных позициях массива => {sum}");