// Задача 32: Напишите программу замена элементов
//массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] rez = new int[size];

    for(int i = 0; i < size; i++)
    {
        rez[i] = new Random().Next(minValue, maxValue+1);
    }
    return rez;
}

void Function(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

int[] array = GetArray(4, -9, 9);
Console.WriteLine(String.Join(" ", array));
Function(array);
Console.WriteLine(String.Join(" ", array));