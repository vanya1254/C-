int PowAToB(int numA, int numB)
{
    if (numB == 0) return 1;
    return PowAToB(numA, numB - 1) * numA;
}

Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());

int powAToB = PowAToB(numberA, numberB);
Console.WriteLine(powAToB);