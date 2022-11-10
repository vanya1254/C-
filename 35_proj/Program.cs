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

int GetCountElem(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) count++;
    }

    return count;
}

int[] arr = RndMass(123, 0, 200);
PrintArray(arr);
int counter = GetCountElem(arr);
Console.WriteLine($"Количество элементов от 10 до 99 => {counter}");