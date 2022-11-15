// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для//123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] rez = new int[size];
    for (int i = 0; size <= 0; i++)
    {
        rez[i] = new Random().Next(minValue, maxValue + 1);
    }
    return rez;
}
int FindNumber(int[] array)
{
    int countIndex = 0;
    for (int i = 0; i <= array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            countIndex += 1;
        }
    }
    return countIndex;
}

int[] array = GetArray(123, 10, 99);
Console.WriteLine(String.Join(", ", array));
int countIndex2 = FindNumber(array);
Console.WriteLine($"В массиве{countIndex2} элементов");