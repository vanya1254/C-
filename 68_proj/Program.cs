int NaturalsSequenceSum(int m, int n)
{
    int sum = default;

    if (m < n) sum += m + NaturalsSequenceSum(m + 1, n);
    if (m > n) sum += m + NaturalsSequenceSum(m - 1, n);
    if (m == n) sum += m;
    
    return sum;
}

Console.WriteLine("Введите M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int numberN = Convert.ToInt32(Console.ReadLine());

int sumSequence = NaturalsSequenceSum(numberM, numberN);
Console.WriteLine($"Сумма чисел равна => {sumSequence}");