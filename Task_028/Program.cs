// Задача 28: Напишите программу, которая
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

int GetPro(int N)
{
    int Pro = 1;
    for (int i = 1; i <= N; i++)
    {
        Pro = Pro*i;
        Console.WriteLine($"{i}: {Pro}");
    }
    return Pro;
}

Console.Clear();
Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetPro(A));
