// Задача 26: Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

//int GetCol(int N)
//{
    //int i = 0;
   // while(i = 1; i <= N; i++)
    //{
    //    i = i+1; 
    //    Console.WriteLine($"Число{N} имеет {i} цифр")
   // }
 //   return i;
//}
//Console.Clear();
//int A = int.Parse(Console.ReadLine()!);
//Console.WriteLine(GetCol(N)); 

int GetCol(int A)
{
    int i = 0;
    while (A != 0)
    {
        A = A/10;
        i = i+1;
    }
    return i;
}
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetCol(N));   

