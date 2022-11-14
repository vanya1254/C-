bool IsTriangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && c + b > a) return true;
    return false;
}

Console.WriteLine("Введите первую сторону");
int aWall = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую сторону");
int bWall = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третью сторону");
int cWall = Convert.ToInt32(Console.ReadLine());

if (IsTriangle(aWall, bWall, cWall))
{
    Console.WriteLine("Треугольник может существовать");
}
else Console.WriteLine("Треугольник не может существовать");