int[] MassiveRandom(int num)
{
    int[] array = new int [num];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000000000);
    }

    return array;
}

void MassivePrint (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)                     // я немного не понял задание поэтому если есть ошибка в смысловом плане программы не снижайте оценку я сделаю как надо, но потребуется объяснение
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}

Console.WriteLine("Введите количество элементов в массиве");
int number = Convert.ToInt32(Console.ReadLine());

int[] rndArray = MassiveRandom(number);
MassivePrint(rndArray);