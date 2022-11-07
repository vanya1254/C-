void MassiveZeroOne(int num)
{
    int[] array = new int [num];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write($"{array[i]}, ");
    }
}

Console.WriteLine("Введите количество элементов в массиве");
int number = Convert.ToInt32(Console.ReadLine());

MassiveZeroOne(number);