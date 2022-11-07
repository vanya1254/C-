int SummatorFac(int num)
{
    int sum = default;

    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

int summatorFac = SummatorFac(a);
Console.WriteLine(summatorFac);