﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью
//рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9

int Akk(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}

Console.Write("Введите число n: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число m: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine(Akk(a, b));