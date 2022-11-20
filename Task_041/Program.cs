// Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] FillArray()
{
    int[] a = new int[M];

    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        a[i] = int.Parse(Console.ReadLine()!);
    }
    return a;
}
Console.Clear();

int[] array = FillArray();
for (int i = 0; i < array.Length; i++)
{
    int count = 0;
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                count = count + array[i];
            }
            return count;
        }
    }
}

int Num = int.Parse(Console.ReadLine()!);
Console.WriteLine(String.Join(",", FillArray(Num)));


//int Function(int M)
//{
//  int[] array = new int[M];
//int count = 0;
//{
//  for (int i = 0; i < array.Length; i++)
//{
//  if (array[i] > 0)
//{
//  count = count + array[i];
//}
//return count;
//  }
//}
//}




