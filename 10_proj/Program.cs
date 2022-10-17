int num = new Random().Next(10, 100);
Console.WriteLine(num);

// int num_1 = num / 10;
// int num_2 = num % 10;

// if (num_1 > num_2)
// {
//     Console.WriteLine(num_1);
// }
// else
// {
//     Console.WriteLine(num_2);
// }


// int MaxDigit = num_1 > num_2 ? num_1 : num_2;  // тернарный оператор
// Console.WriteLine(MaxDigit);


// Console.WriteLine(num_1 > num_2 ? num_1 : num_2);  // тернарный оператор


int MaxDigit(int number)
{
    int num_1 = number / 10;
    int num_2 = number % 10;
    return num_1 > num_2 ? num_1 : num_2;
}

int res = MaxDigit(num);
Console.WriteLine(res);