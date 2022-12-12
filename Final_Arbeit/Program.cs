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
Console.WriteLine();
Console.Clear();

string[] LengthOfElements(string[] array2)
{
    int length = array2.Length;			
	string[] result = new string[length];
	int count = 0;
    
    for (int i = 0; i < length; i++)
    {
        if (array2[i].Length <= 3)
        {
            result[count] = array2[i];
            count++;
        }
    }
    return result;
    
}

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} \t");
    }
    Console.WriteLine();
}


string[] array = FillArray(4);
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

string[] pos = LengthOfElements(array);
Console.WriteLine();
PrintArray(pos);