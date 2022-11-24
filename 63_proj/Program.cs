void NaturalNums(int n)
{
    if (n == 0) return;
    NaturalNums(n - 1);
    Console.Write($"{n} ");
}

Console.WriteLine("Введите число элементов последовательности");
int num = Convert.ToInt32(Console.ReadLine());
NaturalNums(num);

// void NaturalNumbers(int num)
// {
//     if (num > 0)
//     {
//         NaturalNumbers(num - 1);
//         Console.Write($"{num} ");
//     }
// }

// NaturalNumbers(number);