Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 != 0)
{
    Console.Write($"Число {num} не является четным");
}
else
{
    Console.Write($"Число {num} является четным");
}