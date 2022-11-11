double[] RndDoubleMass(int size, int mn, int mx)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (mx - mn) + mn), 2);        
    }

    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

// int GetDiffElem(int[] array)
// {
//     int different = 0;

//     different = array.Max() - array.Min();         //  с помощью встроенных методов min max

//     return different;
// }

double[] GetMinMaxtElem(double[] array, int mn, int mx)
{
    double doubleMN = Convert.ToDouble(mn);
    double mdoubleMX = Convert.ToDouble(mx);

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > mdoubleMX) mdoubleMX = array[i];
        if (array[i] < doubleMN) doubleMN = array[i];
    }

    return new double[]{doubleMN, mdoubleMX};
}

double GetDiffElem(double[] array)
{
    double different = 0;

    different = array[1] - array[0];

    return different;
}

int countElements = 5;
int min = 0;
int max = 100;

double[] arr = RndDoubleMass(countElements, min, max);
PrintArray(arr);

double[] arrMinMax = GetMinMaxtElem(arr, max, min);
double diff = GetDiffElem(arrMinMax);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива => {diff}");