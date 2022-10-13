Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int lastDigit = num % 10;
Console.WriteLine($"Последняя цифра числа равна {lastDigit}");