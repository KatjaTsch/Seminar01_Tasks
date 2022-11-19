// Задача 44: Не используя рекурсию, выведите первые N чисел
//Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

int[] Function(int N)
{
    if (N == 1) return new int[1] { 0 };
    if (N == 2) return new int[2] { 0, 1 };
    int[] array = new int[N];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < N; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}
int Num = int.Parse(Console.ReadLine()!);
Console.WriteLine(String.Join(",", Function(Num)));