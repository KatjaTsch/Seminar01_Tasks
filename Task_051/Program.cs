// Задача 51: Задайте двумерный массив.
//Найдите сумму элементов, находящихся на главной диагонали (с
//индексами (0,0); (1;1) и т.д.


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

int DiaganolSum(int[,] inArray)
{
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += inArray[i, i];
            }
        }
    }
    Console.WriteLine();
    return sum;
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] WorkingArray = GetArray(rows, cols, 0, 10);
PrintArray(WorkingArray);

Console.Write($"Сумма элементов на гл диагонали равна {DiaganolSum(WorkingArray)} ");
