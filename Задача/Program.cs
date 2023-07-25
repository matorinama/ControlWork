/*Задача: Написать программу, которая из имеющегося массива строк формирует 
новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/



Console.Clear();
//1
Console.WriteLine("Введите первоначальный массив через пробел (можно использовать любые слова, символы, эмодзи, цифры):");
string [] st = Console.ReadLine().Split();

//4
Console.WriteLine("Критериям соответствуют:");
PrintStringArray(SymbolLimit3(st));


//2
string[] SymbolLimit3 (string[] array)
{
    int size = 0; // для определения какого размера понадобится новый массив с результатом
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) size++;
    }
    string[] result = new string [size];
    int k = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3) 
        {
            result[k] = array[j];
            k++;
        }
    }
    return result;
}

//3
void PrintStringArray(string[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(array[position]);
        position++;
    }
}

