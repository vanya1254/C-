Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = 0, min = 0;

if (num1 > num2)
{
    max = num1;
    min = num2;
}
else if (num1 < num2)
{
    max = num2;
    min = num1;
}
else
{
    Console.WriteLine("Вводите числа заведомо неравные");
}
Console.Write($"Меньшее число {min}, большее число {max}");