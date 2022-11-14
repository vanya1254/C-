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

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }

    return newArray;
}

int[] rndArr = RndMass(5, 1, 10);
PrintArray(rndArr);
Console.WriteLine();
int[] copyArray = CopyArray(rndArr);
PrintArray(copyArray);