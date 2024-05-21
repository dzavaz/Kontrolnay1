﻿string[] CreateFirstArray() //задаем размер и создаем новый массив строк
{
    Console.Write("Введите длину массива: ");
    int sizeArray = Convert.ToInt32(Console.ReadLine()); //получаем размер массива строк
    while (sizeArray < 1)
    {
        Console.Write("Вы ввели неверное значение, повторите ввод: ");
        sizeArray = Convert.ToInt32(Console.ReadLine());
    }

    string[] firstArray = new string[sizeArray];
    for (int i = 0; i < sizeArray; i++)//заполняем массив строк
    {
        Console.Write($"Введите {i + 1} строку: ");
        firstArray[i] = Console.ReadLine();
    }
    return firstArray;
}

int FindSizeNewArray(string[] firstArray, int maxSymbolLength) // вычисляем размер нового массива по условиям
{
    int count = 0;
    foreach (string v in firstArray)
    {
        if (v.Length <= maxSymbolLength) count++;
    }
    return count;
}

string[] CreateAndFillNewArray(string[] firstArray, int sizeNewArray, int maxSymbolLength)//создаем новый массив по условиям
{
    string[] newArray = new string[sizeNewArray];
    int index = 0;
    foreach (string v in firstArray)
    {
        if (v.Length <= maxSymbolLength)
        {
            newArray[index] = v;
            index++;
        }
    }
    return newArray;
}

Console.Clear();
int maxSymbolLength = 3;
string[] firstArray = CreateFirstArray();
int sizeNewArray = FindSizeNewArray(firstArray, maxSymbolLength);
string[] newArray = CreateAndFillNewArray(firstArray, sizeNewArray, maxSymbolLength);
Console.WriteLine("Вот оно искомое");
Console.WriteLine(string.Join(" ", newArray));
Console.WriteLine();