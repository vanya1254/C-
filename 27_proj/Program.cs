int FactNum(int num)
{
    int factNum = 1;

    for (int i = 1; i <= num; i++)
    {
        factNum *= i;
    }

    return factNum;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int factNumber = FactNum(number);
Console.WriteLine($"Факториал числа {number} равен {factNumber}");