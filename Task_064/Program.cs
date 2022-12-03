// Задача 64: Задайте значение N. Напишите программу, которая выведет все
//натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


String NaturalNumbers(int a, int N)
{
    if(N == a) return N.ToString();
    Console.Write(N);
    return $"{NaturalNumbers(1, N - 1)}, {N}";
}

Console.Write("Введите число: ");
int c = int.Parse(Console.ReadLine()!); 

Console.Write("Введите число: ");
int d = int.Parse(Console.ReadLine()!); 

NaturalNumbers(c, d);
Console.WriteLine(NaturalNumbers(c, d));