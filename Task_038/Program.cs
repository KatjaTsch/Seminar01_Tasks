// Задача 38: Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным элементом
//массива.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int Rasn(int[] array)
{

    int diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int max = array[i];
        int min = array[i];
        
        if (array[i] > max) 
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        } 
        diff = max - min;
    }
    return diff;
}
int[] array = GetArray(5, 5, 10);
Console.WriteLine(String.Join(",", array));
int different = Rasn(array);
Console.WriteLine($"Разница равна {different}");