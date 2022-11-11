// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
    int size;

    if (array.Length % 2 == 0)
    {
        size = array.Length / 2;
        int[] arrayMult = new int[size];

        for (int i = 0; i < array.Length / 2; i++)
        {
            arrayMult += array[i] * array[-1 - i];
        }
        return arrayMult;
    }

    size = array.Length / 2 + 1;
    int[] arrayMult = new int[size];

    for (int i = 0; i < array.Length / 2; i++)
    {
        arrayMult += array[i] * array[-1 - i];
    }
    arrayMult += array[array.Length / 2];

    return arrayMult;
}

int[] arr = RndMass(5, 1, 9);
PrintArray(arr);

int multArr = MultiArray(arr);
Console.WriteLine($"{multArr}");