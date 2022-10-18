int DivNum(int number1, int number2)
{
    int Div = number1 % number2;
    return Div;
}

Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

int res = DivNum(num1, num2);

if (res == 0)
{
    Console.WriteLine($"Число {num1} кратно {num2}!");
}
else
{
    Console.WriteLine($"Число {num1} не кратно {num2}! Остаток от деления {res}.");
}