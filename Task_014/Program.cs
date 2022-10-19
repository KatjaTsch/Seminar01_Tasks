// 14. Напишите программу, которая принимает на
//вход число и проверяет, кратно ли оно
// одновременно 7 и 23.

Console.WriteLine("Введите число: ");

int numb = int.Parse(Console.ReadLine()!);

if(numb % 7 == 0 && numb % 23 == 0)
{
    Console.WriteLine($"Число {numb} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {numb} НЕ кратно 7 и 23");
}