﻿int ReverseNumber(int num2)
{
    int result = default;

    while (num2 > 9 || num2 > 0)
    {
        result += num2 % 10;
        result *= 10;
        num2 /= 10;
    }
    result += num2 % 10;

    return result;
}

System.Console.WriteLine("Введите число десятичной системы исчисления");
int number10 = Convert.ToInt32(Console.ReadLine());

int ConvertToBin(int num10)
{
    int num2 = default;

    while (num10 > 0)
    {
        num2 += num10 % 2;
        num2 *= 10;
        num10 /= 2;
        ConvertToBin(num10);
    }

    return num2;
}

int number2Rev = ConvertToBin(number10);
int number2 = ReverseNumber(number2Rev);
Console.WriteLine(number2);