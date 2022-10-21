double DotsDistance (double xA, double yA, double zA, double xB , double yB, double zB)
{
    double xBxA = xB - xA;
    double yBxA = yB - yA;
    double zBzA = zB - zA;

    double xY = Math.Sqrt((Math.Pow(xBxA, 2) + Math.Pow(yBxA, 2) + Math.Pow(zBzA, 2)));
    return xY;
}

Console.WriteLine();
Console.WriteLine("Давайте найдем расстояние между двумя точками в пространстве по вашим координатам!");
Console.WriteLine();

Console.Write("Введите X1 -> ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Y1 -> ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Z1 -> ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите X2 -> ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Y2 -> ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Z2 -> ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Round(DotsDistance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками равно {distance}");