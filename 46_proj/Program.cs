int CheckCoeff(double b1, double k1, double b2, double k2)
{
    int flag = default;

    if (k1 != k2) flag = 0;
    else if (k1 == k2)
    {
        if (b1 == b2) flag = 1;
        else flag = 2;
    }

    return flag;
}

double[] GetIntersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    return new double[] { x, y };
}

Console.WriteLine("Запущена программа по нахождению точки пересечения прямых: y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine();

Console.WriteLine("Введите b1");
double userB1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k1");
double userK1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2");
double userB2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k2");
double userK2 = Convert.ToDouble(Console.ReadLine());

int checkCoeff = CheckCoeff(userB1, userK1, userB2, userK2);
Console.WriteLine();

if (checkCoeff == 0)
{
    double[] intersection = GetIntersection(userB1, userK1, userB2, userK2);
    Console.WriteLine($"Точка пересечения ({intersection[0]}; {intersection[1]})");
}
else if (checkCoeff == 1) Console.WriteLine($"Прямые равны");
else if (checkCoeff == 2) Console.WriteLine($"Нет пересечений");