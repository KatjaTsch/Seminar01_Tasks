// Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

void newArray(int[] GetArray)
{
    for(int i = 0; i < GetArray.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}  ");
        GetArray[i] = int.Parse(Console.ReadLine()!);
    }
}

String ArrayToString(int[] array)
{
    return "[" + String.Join(" , ", array) + "]";
}

int SumNum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum++;
    }
    return sum;
}

Console.Clear();
Console.WriteLine($"Введите количество элементов массива");
int numCount = int.Parse(Console.ReadLine()!);
int[] GetArray = new int[numCount];
newArray(GetArray);
int Sum = SumNum(GetArray);
Console.WriteLine(ArrayToString(GetArray));
Console.WriteLine($"Количество положительных чисел: {Sum}");




