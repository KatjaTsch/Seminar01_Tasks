// Напишите программу, которая из имеющегося массива строк сформирует массив строк, 
//длина которых меньше либо равна 3 символа. Первонач. массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.

int[] FillArray(int size, int minValue, int maxValue)
{
    int[] a = new int[4];

    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(minValue, maxValue + 1);
    }
    return a;
}
Console.Clear();

int[] array = FillArray(4, 100, 9999);
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
