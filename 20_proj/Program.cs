double Distance (double a, double b, double c, double d)
{
    double xY = Math.Sqrt((c - a) * (c - a) + (d - b) * (d - b));
    return xY;
}

Console.WriteLine("Введите X1");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y1");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите X2");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y2");
double y2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Round(Distance(x1, y1, x2, y2), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точкой с координатами: ({x1}, {y1}) и точкой с координатами: ({x2}, {y2}) равно {result}");