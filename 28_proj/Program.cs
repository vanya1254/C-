int[] MassiveZeroOne(int num)
{
    int[] array = new int [num];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }

    return array;
}

void MassivePrint (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}

Console.WriteLine("Введите количество элементов в массиве");
int number = Convert.ToInt32(Console.ReadLine());

int[] rndArray = MassiveZeroOne(number);
MassivePrint(rndArray);