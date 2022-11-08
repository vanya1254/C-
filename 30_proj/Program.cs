int SumDigits(int num)
{
    int sum = default;
    num = Math.Abs(num);
    
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }

    return sum;
}

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigits(number);
Console.WriteLine($"Сумма цифр числа {number} равна {sumDigits}");