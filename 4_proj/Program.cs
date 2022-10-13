Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int count = -number;
    while (count <= number)
    {
        Console.Write($"{count} ");
        count++;
        //count = count + 1;
    }
}
else Console.WriteLine("Введите целое положительное число!");