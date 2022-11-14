// Задача 33: Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] rez = new int[size];

    for(int i = 0; i < size; i++)
    {
        rez[i] = new Random().Next(minValue, maxValue+1);
    }
    return rez;
}

void FindNumber(int[] array, int N)
{
    for(int i = 0; i <= array.Length; i++)
    {
        if (array[i] == N)
        {
            Console.Write("ДА ");
            return;    
        }
    }
    Console.Write("Нет ");
}

int[] array = GetArray(5, -9, 9);
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(String.Join(" ", array));
FindNumber(array, N);