int SumDigitalsNum(int num)
{
    if (num > 0) return num % 10 + SumDigitalsNum(num / 10);
    return 0;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigitalsNum(number);
Console.WriteLine(sumDigits);