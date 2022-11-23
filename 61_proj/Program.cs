int[,,] CreateArray3D(int rows, int columns, int depth, int mn, int mx)
{
    int[,,] array3D = new int[rows, columns, depth];

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)                   // в конце пример, как я пытался сделать неповторяющиеся числа сразу в одном методе, но в итоге не получилось
            {                                                                // нашел ответ в интернете, но я там многое еще не изучал даже, решил что лучше так чем чужое без особого понимания
               if (mn < mx) array3D[i, j, k] = mn++;
            }
        }
    }

    return array3D;
}

void PrintMatrix(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k],5}  {(i, j, k)}  |");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] array3D = CreateArray3D(2, 2, 2, 10, 100);

if (array3D.Length < 91) PrintMatrix(array3D);                              // проверка на повторения так сказать
else Console.WriteLine("Пока ограничено по количеству 'случайных' чисел");


// int[,,] CreateRndDiffElemArray3D(int rows, int columns, int depth, int mn, int mx)
// {
//     int[,,] array3D = new int[rows, columns, depth];
//     Random rnd = new Random();
//     bool diffFalse = true;

//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {   
//                 while(diffFalse)
//                 {
//                     int rndDiff = rnd.Next(mn, mx + 1);

//                     for (int l = 0; l < array3D.GetLength(0); l++)
//                     {
//                         for (int g = 0; g < array3D.GetLength(1); g++)
//                         {
//                             for (int h = 0; k < array3D.GetLength(2); h++)
//                             {
//                                 if (array3D[l, g, h] == rndDiff) diffFalse = true;
//                                 else diffFalse = false;
//                             }
//                         }
//                     }

//                     if (diffFalse) array3D[i, j, k] = rndDiff;
//                 }
//             }
//         }
//     }

//     return array3D;
// }