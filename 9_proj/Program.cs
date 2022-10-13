Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (num >= count)
{
    while (num >= count)
    {
        Console.Write($"{count}; ");
        count = count + 2;
    }
}
else
{
    Console.Write($"Нет четных чисел в диапазоне от 1 до {num}");
}