// Задача 21 Напишите программу, 
//которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

double GetLen(double x1, double x2, double y1, double y2, double z1, double z2)
{
  double result = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
   return result;  
}
Console.Clear();
Console.Write("x1 = ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("y1 = ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("z1 = ");
double z1 = double.Parse(Console.ReadLine()!);
Console.Write("x2 = ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("y2 = ");
double y2 = double.Parse(Console.ReadLine()!);
Console.Write("z2 = ");
double z2 = double.Parse(Console.ReadLine()!);
Console.WriteLine($"L = {GetLen(x1, y1, z1, x2, y2, z2)}");



//int[] array = {x1, y1, z1, x2, y2, z2, x3, y3, z3};

//
//int xyz = GetLen(
    //GetLen(array[x1], array[y1], array[z1]),
    //GetLen(array[x2], array[y2], array[z2]),
    //GetLen(array[x3], array[y3], array[z3])
//);
