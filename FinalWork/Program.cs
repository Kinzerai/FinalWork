//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно 
//ввести с клавиатуры, либо задать на старте выполнения алгоритма. 


Console.Clear();

Console.WriteLine("Для создания массива заполните любыми символами элементы массива.");

string [] array = new string [5];

void FillArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i+1} элемент массива");
    array[i] = Convert.ToString(Console.ReadLine());
}
}

void PrintArray(string[] array)

{
    Console.Write("Массив {");
for (int j = 0; j < array.Length; j++)
{
    Console.Write(" " + array[j] + " ");
}
Console.Write("} ");
}


FillArray(array);
PrintArray(array);

string[] FillNewArray(string[] array)

{
    int NewArrayLength = 0;
    for (int k = 0; k < array.Length; k++)
    {
        if (array[k].Length < 4)
        {
            NewArrayLength = NewArrayLength + 1;
        }
    }

    string[] NewArray = new string[NewArrayLength];

    for (int m = 0, l = 0; m < array.Length; m++)
    {
        if (array[m].Length < 4) 
        {
            NewArray[l] = array[m];
        l++;
        }
    }
    return NewArray;
}

FillNewArray(array);
Console.Write(" -> ");
PrintArray(FillNewArray(array));
Console.WriteLine();



