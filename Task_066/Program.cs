// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumDigits(int N, int M)
{
    int a = M;
    int b = N;
    if (M > N)
    {
       a = N;
       b = M; 
    } 
    return (a + b)*(b - a + 1)/2;
}

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!); 

Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine()!); 

Console.WriteLine(SumDigits(a, b));