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

int[] MultiArray(int[] array)
{
    int size = default;

    if (array.Length % 2 == 0)
    {
        size = array.Length / 2;
        int[] arrayMult = new int[size];

        for (int i = 0; i < size; i++)
        {
            arrayMult[i] = array[i] * array[array.Length - 1 - i];
        }

        return arrayMult;
    }
    else
    {
        size = array.Length / 2 + 1;
        int[] arrayMult = new int[size];

        for (int i = 0; i < size; i++)
        {
            arrayMult[i] = array[i] * array[array.Length - 1 - i];
        }
        arrayMult[size - 1] = array[array.Length / 2];

        return arrayMult;
    }
}

int[] arr = RndMass(7, 1, 9);
PrintArray(arr);

int[] multArr = MultiArray(arr);
PrintArray(multArr);