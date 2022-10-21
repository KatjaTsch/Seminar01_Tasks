// Задача 10: Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.

Console.Clear();

Console.WriteLine("Введите трёхзначное число:");
int number = int.Parse(Console.ReadLine()!); 

int a3 = number % 10;
int a2 = ((number - a3) % 100)/10;

Console.WriteLine($"{a2}");
