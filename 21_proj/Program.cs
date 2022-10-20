// void QuadNum (int quad)
// {
//     int count = 1;
//     while (quad >= count)
//     {
//         Console.WriteLine($"{count} => {count * count}");
//         count++;
//     }
// }

void QuadNum(int quad)
{
    if (quad > 0)
    {
        for (int i = 1; i <= quad; i++)
        {
            Console.WriteLine($"|{i, 5} | {i * i, 5}|");
        }
    }
    else Console.WriteLine("Введите значение больше 0");
}

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

QuadNum(num);

// if (num > 0) QuadNum(num);
// else Console.WriteLine("Введите натуральное число!");