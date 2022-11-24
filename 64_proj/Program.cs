void NaturalNums(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m} ");
        NaturalNums(m + 1, n);
    }

    if (m > n)
    {
        Console.Write($"{m} ");
        NaturalNums(m - 1, n);
    }

    if (m == n)
    {
        Console.Write($"{m} ");
    }
}

Console.WriteLine("Введите первое число последовательности");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число последовательности");
int num2 = Convert.ToInt32(Console.ReadLine());
NaturalNums(num1, num2);