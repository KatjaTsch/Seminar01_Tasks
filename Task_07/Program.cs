// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write ("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!); 

int a = number % 10;

Console.Write($"Последняя цифра {a}");