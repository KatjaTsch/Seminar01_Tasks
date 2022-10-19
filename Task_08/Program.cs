// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write ("Введите число: ");
int N = int.Parse(Console.ReadLine()!); 

int number = 1;
number += 1;


while (number <= N);

if(number % 2 == 0)
{
    Console.Write ($"{number}, ");
}
            
            
