// Задача 56: Задайте прямоугольный двумерный массив. Напишите
//программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] Summ(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + (array[i, j]);
        }
        Console.WriteLine($"{sum}");
    }
    Console.WriteLine();
    return array;
}

int StringSummMin(int[,] array2)
{
    int[,] newarray = new int[array2.GetLength(0), array2.GetLength(1)];
    int temp = 0;
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            int min = array2[i, j];
            if (array2[i, j] < min)
            {
                min = array2[i, j];
            }
            temp = min;
        }
    }
    Console.WriteLine($"{temp}");
    return temp;
}


int[,] array = GetArray(3, 3, 0, 10);
PrintArray(array);
Console.WriteLine();

int[,] arraySumm = Summ(array);

StringSummMin(arraySumm);








