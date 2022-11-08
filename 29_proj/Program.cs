double Exponentiation(double num, int degree)
{
    double exponentiation = 1;

    for (int i = 0; i < degree; i++)
    {
        exponentiation *= num;
    }

    return exponentiation;
}

bool IsNatural(int number)
{
    if (number > 0) return true;                                             //  проверка на натуральность степени
    return false;
}

bool condition = true;

Console.WriteLine("Введите число, которое хотите возвести в степень");
double a = Convert.ToDouble(Console.ReadLine());                             //  использовал тип double т.к. сказано что только степень натуральная

while (condition)
{
    Console.WriteLine("Введите натуральную степень");
    int b = Convert.ToInt32(Console.ReadLine());

    if (IsNatural(b))
    {
        double expoA = Exponentiation(a, b);
        System.Console.WriteLine($"Число {a} в степени {b} равно => {expoA}");
        condition = false;
    }
}