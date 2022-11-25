int GetAkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return GetAkkermanFunction(m - 1, 1);           // перевел в код написаное в википедии про функцию, но так и не понял, для чего она
    
    return GetAkkermanFunction(m - 1, GetAkkermanFunction(m, n - 1));    // https://wikimedia.org/api/rest_v1/media/math/render/svg/c8c2aa0b20532014ea35c4a09c2380a01b3d1423
}

Console.WriteLine("Введите M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int numberN = Convert.ToInt32(Console.ReadLine());

int akkermanResult = GetAkkermanFunction(numberM, numberN);
Console.WriteLine($"A({numberM}, {numberN}) = {akkermanResult}");