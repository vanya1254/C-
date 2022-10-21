bool Find5Num (int num5)
{
    if ((num5 > 9999 && num5 < 100000) || (num5 < -9999 && num5 > -100000)) return true;
    return false;
}

double ReverseNum (int num)
{
    double revNum = 0;
    double degree = 4;

    if (num < 0)
    {
        while (num < 0)
        {
            revNum = revNum + (num % 10) * Math.Pow(10, degree);
            num = num / 10;
            degree--;
        }
        return revNum;
    }
    
    while (num > 0)
    {
        revNum = revNum + (num % 10) * Math.Pow(10, degree);
        num = num / 10;
        degree--;
    }
    return revNum;
}

bool FindPalindrome (int num, double revNum)
{
    if (num == revNum) return true;
    return false;
}

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

bool answerFind5 = Find5Num(number);

if (answerFind5)
{
    double reverseNumber = ReverseNum(number);
    bool answerFindPalindrom = FindPalindrome(number, reverseNumber);

    if (answerFindPalindrom) Console.WriteLine($"Число {number} явлется палиндромом");
    else Console.WriteLine($"Число {number} не явлется палиндромом");
}
else
{
    Console.WriteLine("Было введено не пятизначное число");
}