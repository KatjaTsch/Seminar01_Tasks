// Задача 15: Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7: ");
int numb = int.Parse(Console.ReadLine()!);

if (numb == 7 || numb == 6)
{
    Console.WriteLine("Этот день - выходной!");
}
else if(numb > 0 && numb < 6)
{
    Console.WriteLine("Этот день не является выходным");
}
else if(numb < 1 || numb > 7)
{
    Console.WriteLine("Введённая цифра не соответствует дню недели");
}

