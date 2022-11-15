// Задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] rez = new int[size];

    for (int i = 0; i < size; i++)
    {
        rez[i] = new Random().Next(minValue, maxValue + 1);
    }
    return rez;
}

int FindNumber(int[] array)
{
    int countIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countIndex += 1;
        }
    }
    return countIndex;
}

int[] array = GetArray(5, 100, 999);
Console.WriteLine(String.Join(",", array));
int countIndex2 = FindNumber(array);
Console.WriteLine($"В массиве :{countIndex2} чётных элементов");