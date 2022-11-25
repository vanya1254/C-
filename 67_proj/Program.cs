void NaturalsSequence(int n)
{
    if (n == 0) return;
    Console.Write($"{n} ");
    NaturalsSequence(n - 1);
}

Console.WriteLine("Введите первое число последовательности");
int number = Convert.ToInt32(Console.ReadLine());
NaturalsSequence(number);