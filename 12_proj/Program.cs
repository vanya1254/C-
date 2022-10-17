// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


int DivNum(int number1, int number2)
{
    int Div = number1 % number2;
    if (Div > 0)
    {
        return Div;
    }
    else
    {
        return Div
    }
}

int res = DivNum(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));


Console.WriteLine(res);