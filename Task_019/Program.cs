// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

static void Polindrom()
{
    Console.WriteLine("Введите пятизначное число: ");
    int N = int.Parse(Console.ReadLine()!);
    if (((N % 100000 - N % 10000) / 10000 == N % 10) && (N % 10000 - N % 1000) / 1000 == (N % 100 - N % 10)/10)
    {
       Console.WriteLine($"{N} является палиндромом!"); 
    }
    else
    {
        Console.WriteLine($"{N} НЕ является палиндромом");
    }
} 
Polindrom();




//int N = int.Parse(Console.ReadLine()!);

//if (((N % 100000 - N % 10000) / 10000 == N % 10) && (N % 10000 - N % 1000) / 1000 == (N % 100 - N % 10)/10)
//{
  //  Console.WriteLine($"{N} является палиндромом");
//}
//else
//{
  //  Console.WriteLine($"{N} НЕ является палиндромом");
//}






