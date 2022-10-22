﻿// Задача 22: Напишите программу, которая
//принимает на вход число (N) и выдаёт таблицу
//квадратов чисел от 1 до N.

String GetPows (int N)
{
    string result = "";
    for (int i=1; i<=N-1; i++)
    {
        result += (i*i).ToString()+", ";
    }
    result += (N*N).ToString();
    return result;
}

Console.Write("Введите N ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetPows(n));