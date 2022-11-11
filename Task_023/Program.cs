//Задача 23: Напишите программу, которая принимает на
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 4, 9.
//5 -> 1, 8, 27, 64, 125

String GetPows (int N)
{
    string result = "";
    for (int i=1; i<=N-1; i++)
    {
        result += (i*i*i).ToString()+", ";
    }
    result += (N*N*N).ToString();
    return result;
}

Console.Write("Введите число N ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetPows(n));
