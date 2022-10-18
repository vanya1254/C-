int SecondNum (int num)
{
    int SecNum = (num % 100) / 10;
    return SecNum;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int res = SecondNum(number);
    System.Console.WriteLine($"Вторая цифра числа {number} равна {res}");
}
else
{
    Console.WriteLine($"{number} не является трехзначным числом!");
}