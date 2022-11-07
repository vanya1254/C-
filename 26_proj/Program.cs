int CountNum(int num)
{
    int count = 0;
    num = Math.Abs(num);

    while (num > 0)
    {
        num /= 10;
        count++;
    }
    return count > 0 ? count : 1;
}

// int CountNum(int num)
// {
//     int count = 0;
//     num = Math.Abs(num);

//     for (int i = num; i > 0; i /= 10)
//     {
//         count++;
//     }
//     return count > 0 ? count : 1;
// }

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int countNum = CountNum(number);

Console.WriteLine($"У вашего числа {countNum} цифр(ы)");