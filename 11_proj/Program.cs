int RmSecondNum (int number)
{
    int FirstDig = number / 100;
    int ThirdhDig = number % 10;
    int num1_3 = FirstDig * 10 + ThirdhDig;
    return num1_3;
}

int num = new Random().Next(100, 1000);
Console.WriteLine($"Выбрано трехзначное число {num}");

int res = RmSecondNum(num);
Console.WriteLine($"Преобразовано в двузначное {res}");