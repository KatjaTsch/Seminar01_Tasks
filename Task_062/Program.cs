// Задача 62: Заполните спирально массив 4 на 4.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 17);

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
            if (inArray[i, j] == inArray.GetLength(0) - 1)
            {
                inArray[i, j] = inArray[i - 1, j];
            }
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}


int[,] array = GetArray(2, 2, 0, 16);
PrintArray(array);
Console.WriteLine();


