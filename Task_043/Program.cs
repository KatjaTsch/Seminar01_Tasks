// Задача 43: Напишите программу, которая найдёт 
//точку пересечения двух прямых, 
//заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int TwoLine(int b1, int k1, int b2, int k2)
{
    if (k1 == k2)
    {
        Console.Write("Прямые параллельны");
    }
    else
    {
        int x = (b2 - b1) / (k1 - k2);
        int y = k2 * ((b2 - b1) / (k1 - k2)) + b2;
    }
    return;
}

Console.Write("Введите число b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число k2: ");
int k2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(TwoLine(b1, k1, b2, k2));

//y = {k1}*x + {b1} и y = {k2}*x + {b2} пересекаются в точке 