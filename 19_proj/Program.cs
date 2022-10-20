string Quarter (int quart)
{
    if (quart == 1) return $"x > 0 && y > 0";
    if (quart == 2) return $"x < 0 && y > 0";
    if (quart == 3) return $"x < 0 && y < 0";
    if (quart == 4) return $"x > 0 && y < 0";
    return "Введено некоректное значение";
}

Console.WriteLine("Введите номер четверти");
int quartCons = Convert.ToInt32(Console.ReadLine());

string result = Quarter(quartCons);
Console.WriteLine(result);