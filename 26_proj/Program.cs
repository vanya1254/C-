int CountNum(int num)
{
    int count = 0;

    while (num > 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

// int CountNum(int num)
// {
//     int count = 0;

//     for (int i = num; i > 0; i /= 10)
//     {
//         count++;
//     }
//     return count;
// }

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int countNum = CountNum(number);

Console.WriteLine($"У вашего числа {countNum} цифры");