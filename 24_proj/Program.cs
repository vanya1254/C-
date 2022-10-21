void CubedNum(int cube)
{
    if (cube > 0)
    {
        for (int i = 1; i <= cube; i++)
        {
            Console.WriteLine($"|{i, 4} | {Math.Pow(i, 3), 5}|");
        }
    }
    else Console.WriteLine("Введите значение больше 0");
}

Console.WriteLine();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

CubedNum(num);