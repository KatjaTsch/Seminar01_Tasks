// Задача 59: Задайтедвумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец, на
//пересечении которых расположен наименьший элемент
//массива.

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

int[] GetArrayIndexMin(int[,] array)
{
    int indexI = 0;
    int indexJ = 0;
    for(int i = 1; i < array.GetLength(0); i++)
    {
        for(int j = 1; j < array.GetLength(1); j++)
        {
            if(array[i, j] < array[indexI, indexJ]) {indexI = i; indexJ = j; }
        }
    }
    return new int[2]{indexI, indexJ};
}

int[,] ModArray(int[,] array, int[] excludeItem)
{
    int[,] newarray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int row = 0;
    int col = 0;
    for(int i = 1; i < array.GetLength(0); i++)
    {
        if(i == excludeItem[0]) {continue;}
        for(int j = 1; j < array.GetLength(1); j++)
        {
            if(j == excludeItem[1]) {continue;}
            newarray[row, col] = array[i, j];
            col++;
        }
        row++; col = 0;
    }
    return newarray;
}

int[,] myArray = GetArray(3, 3, 0, 10);
int[] minElement = GetArrayIndexMin(myArray);
int[,] myBestArray = ModArray(myArray, minElement);

PrintArray(myArray);
Console.WriteLine();
PrintArray(myBestArray);