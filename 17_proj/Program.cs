// bool FindWeekDay (int num)
// {
//     if (num > 0 && num < 8)
//     {
//         return true;
//     }
//     return false;
// }

// bool FindWeekends (int weekDay)
// {
//     if (weekDay == 6 || weekDay == 7)
//     {
//         return true;
//     }
//     return false;
// }

// Console.WriteLine("Введите число соответствующее номеру дня недели");
// int day = Convert.ToInt32(Console.ReadLine());

// bool answerFWD = FindWeekDay(day);                                                     //  Полностью рабочий код, но с множеством лишнего функционала, ниже попробую сделать меньше и конкретнее

// if (answerFWD)
// {
//     bool answerFWeekends = FindWeekends(day);
//     if (answerFWeekends)
//     {
//         Console.WriteLine($"Число {day} соответствует выходному дню");
//     }
//     else
//     {
//         Console.WriteLine($"Число {day} не соответствует выходному дню");
//     }
// }
// else
// {
//     Console.WriteLine($"Число {day} не соответствует дню недели и не является выходным");
// }


bool FindWeekends (int weekDay)
{
    if (weekDay == 6 || weekDay == 7)
    {
        return true;
    }
    return false;
}

Console.WriteLine("Введите число соответствующее номеру дня недели");
int day = Convert.ToInt32(Console.ReadLine());

bool weekend = FindWeekends(day);

if (weekend)
{
    Console.WriteLine($"{day} является выходным днем");
}
else
{
    Console.WriteLine($"{day} не является выходным днем");
}