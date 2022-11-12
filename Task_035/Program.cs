// Задача 25: Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную
//степень B. Реализовать функцию возведения в степень
//самостоятельно!

int Stepen(int A, int B)
{
   int pow = 1;
   {
      for(int i = 0; i < B; i++)
      {
         pow *= A;
      }
      return pow;
   }  
}
Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень числа");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{a} в степени {b} = {Stepen(a, b)}");


