// Задача. Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] strArray = {"cat","parrot","duck","dog"};
PrintArray(strArray);
Console.WriteLine();
int numSymbols = 3;
int size = SizeNewStrArray(strArray);
string[] newStrArray = CreateArrayString(size, strArray);
PrintArray(newStrArray);


int SizeNewStrArray(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i].Length <= numSymbols) size++;
    }
    return size;
}

string[] CreateArrayString(int sizeNewArray, string[] array)
{
    string[] newArray = new string[sizeNewArray];
    int position = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numSymbols)
        {
            newArray[position] = array[i];
            position++;
        }
    }
    return newArray;
}

void PrintArray (string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"'{array[i]}', ");
        else Console.Write($"'{array[i]}'");
    } 
    Console.Write("]");
}