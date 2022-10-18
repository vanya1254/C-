bool Have3Num (int num)
{
    if ((num > 99 && num >= 0) || (num < 0 && num < -99))
    {
        return true;
    }
    return false;
}

int Find3Num (int num)
{
    while ((num > 999 && num >= 0) || (num < 0 && num < -999))
    {
        num = num / 10;
    }
    int thirdNum = num % 10;
    if (thirdNum < 0)
    {
        return -thirdNum;
    }
    return thirdNum;
}

Console.WriteLine("Введите число, лучше трехзначное (вдруг не сработает)");
int number = Convert.ToInt32(Console.ReadLine());

bool resH3N = Have3Num(number);

if (resH3N)
{
    int resF3N = Find3Num(number);
    Console.WriteLine($"Трертья цифра числа {number} равна {resF3N}");
}
else
{
    Console.WriteLine($"У числа {number} нет третьей цифры");
}