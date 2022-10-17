Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 * num1 == num2)
{
    Console.WriteLine($"Число {num2} явлется квадратом числа {num1}");
}
else
{
    Console.WriteLine($"Число {num2} не явлется квадратом числа {num1}");
}