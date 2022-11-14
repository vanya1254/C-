bool IsTriangle(int a, int b, int c)
{
    return a + b > c && a + c > b && c + b > a;
}

Console.WriteLine("Введите первую сторону");
int aWall = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую сторону");
int bWall = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третью сторону");
int cWall = Convert.ToInt32(Console.ReadLine());

bool isTriangle = IsTriangle(aWall, bWall, cWall);
Console.WriteLine(isTriangle == true ? "Треугольник может существовать" : "Треугольник не может существовать");