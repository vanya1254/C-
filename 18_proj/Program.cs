int Quarter (double arg1, double arg2)
{
    if (arg1 > 0 && arg2 > 0) return 1;
    if (arg1 < 0 && arg2 > 0) return 2;
    if (arg1 < 0 && arg2 < 0) return 3;
    if (arg1 > 0 && arg2 < 0) return 4;
    return 0;
}

Console.WriteLine("Введите X");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Y");
double y = Convert.ToDouble(Console.ReadLine());

int quart = Quarter(x, y);
string result = quart > 0 
    ? $"Указанные координаты соответствуют четверти => {quart}" 
    : "Введены некорректные координаты";

Console.WriteLine(result);

// Console.WriteLine($"Данная точка находится в {Quarter(x, y)} четверти");