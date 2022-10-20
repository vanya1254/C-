void QuadNum (int quad)
{
    int count = 1;
    while (quad >= count)
    {
        Console.WriteLine($"{count} => {count * count}");
        count++;
    }
}

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0) QuadNum(num);
else Console.WriteLine("Введите натуральное число!");