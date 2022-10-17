bool DivNum(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
    {
        return true;
    }
    return false;
}
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
bool res = DivNum(num);

if (res)
{
    Console.WriteLine($"Число {num} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {num} не кратно 7 и 23");
}