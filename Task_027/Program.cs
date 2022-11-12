// Задача 27: Напишите функцию и запустите ее, которая
//принимает на вход число и выдаёт сумму цифр в числе.

int GetSum(int N)
{
    int sum = 0;
    while(N != 0)
    {
        sum = sum + N % 10;
        N = N / 10;
    }    
    return sum;
}

Console.Clear();
Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма числа {A} равна {GetSum(A)}");
