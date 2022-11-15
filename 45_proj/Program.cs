int[] UserNums(int userCounter)
{
    int[] arrayUserNums = new int[userCounter];

    for (int i = 0; i < userCounter; i++)
    {
        arrayUserNums[i] = Convert.ToInt32(Console.ReadLine());
    }

    return arrayUserNums;
}

int CounterMoreZero(int[] arrayUserNums)
{
    int count = default;

    for (int i = 0; i < arrayUserNums.Length; i++)
    {
        if (arrayUserNums[i] > 0) count++;
    }

    return count;
}

Console.WriteLine("Сколько чисел хотите ввести?");
int userCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] userNums = UserNums(userCount);
int counterMoreZero = CounterMoreZero(userNums);
Console.WriteLine($"Количество чисел больше нуля равно => {counterMoreZero}");