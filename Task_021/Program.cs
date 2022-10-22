// Задача 21: Напишите программу, которая
//принимает на вход координаты двух точек и
//находит расстояние между ними в 2D
//пространстве.
//A (3,6); B (2,1) -> 5,10
//A (7,-5); B (1,-1) -> 7,21

double GetLen(double x1, double y1, double x2, double y2)
{
    double result = Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2)), 1);
    return result;
}

Console.Clear();

Console.Write ("x1 = ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write ("y1 = ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write ("x2 = ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write ("y2 = ");
double y2 = double.Parse(Console.ReadLine()!);

Console.WriteLine ($"L = {GetLen(x1, y1, x2, y2)}");
