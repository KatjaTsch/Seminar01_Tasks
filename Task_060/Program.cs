// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
//двузначных чисел. Напишите программу, которая будет построчно выводить
//массив, добавляя индексы каждого элемента.

int[,,] GetArray(int m, int n, int k, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, k];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int c = 0; c < k; c++)
            {
                result[i, j, c] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int c = 0; c < inArray.GetLength(2); c++)
            {
                Console.Write($"{inArray[i, j, c]} \t");
            }
        }
    }
    Console.WriteLine();
}

int[] Convert1d(int[,,] array)
{
    int[] newarray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                newarray[index++] = array[i, j, c];
                Console.Write($"{array[i, j, c]} \t");
            }

        }

    }
    return newarray;
}




int[,,] array = GetArray(2, 2, 2, 0, 10);
PrintArray(array);
Console.WriteLine();

int[] newarray = Convert1d(array);
Console.WriteLine(String.Join(" ", newarray));


