// Задача 13: Напишите программу, которая выводит
//третью цифру (справа налево) заданного числа или
//сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!); 

int result = (number % 1000 - number % 100)/100;
if(number > 99)
{
    Console.WriteLine($"Третья цифра - {result}!");
}
else
{
Console.WriteLine("третьей цифры нет");
}
    

