// Напишите программу, которая из имеющегося массива строк сформирует массив строк, 
//длина которых меньше либо равна 3 символа. Первонач. массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.

string[] FillArray(int size)
{
    string[] a = new string[size];

    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива: ");
        a[i] = Console.ReadLine();
    }
    return a;
}

Console.Clear();