// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
//произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

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

int[,] MatrixPow(int[,] array, int[,] newarray)
{
    int[,] result = new int[array.GetLength(0), newarray.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < newarray.GetLength(1); k++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result[i, k] += newarray[j, k] * array[i, j];
            }
            Console.Write("{0} ", result[i, k]);
        }
        Console.WriteLine();
    }
    return result;
}



int[,] array = GetArray(2, 2, 0, 10);
PrintArray(array);
Console.WriteLine();

int[,] array2 = GetArray(2, 2, 0, 10);
PrintArray(array2);
Console.WriteLine();

int[,] array3 = MatrixPow(array, array2);


