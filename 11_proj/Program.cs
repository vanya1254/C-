int RmSecondNum (int number)
{
    int FirstDig = number / 100;
    int ThirdhDig = number % 10;
    int num1_3 = FirstDig * 10 + ThirdhDig;
    Console.WriteLine(number);
    return num1_3;
}

int res = RmSecondNum(new Random().Next(100, 1000));
Console.WriteLine(res);