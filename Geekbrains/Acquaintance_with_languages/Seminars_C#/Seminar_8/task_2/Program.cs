/*
## Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.


1 2 3   1 4 7   6 1 3  6 1 8
4 5 6   2 5 8   1 7 3  1 7 8
7 8 9   3 6 9   8 1 7  3 7 7

0;0 0;1 0;2  0;0 1;0 2;0   
1;0 1;1 1;2  0;1 1;1 2;1
2;0 2;1 2;2  0:2 1:2 2;2




*/

void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    Console.WriteLine();
    int[,] fill = FillArray(GetRows(), GetColumns(), GetMinValueArray(), GetMaxValueArray());
    Console.WriteLine();
    PrintArray(fill);
    ReplaceRowsOnColumns(fill);
    Console.WriteLine();
    Console.WriteLine("End");
}
int GetRows()
{
    Console.Write("Введите количество строк двумерного массива: ");
    return int.Parse(Console.ReadLine());
}
int GetColumns()
{
    Console.Write("Введите количество столбцов двумерного массива: ");
    return int.Parse(Console.ReadLine());
}
int GetMinValueArray()
{
    Console.Write("Введите минимальное значение для заполнения двумерного массива: ");
    return int.Parse(Console.ReadLine());
}
int GetMaxValueArray()
{
    Console.Write("Введите максимальное значение для заполнения двумерного массива: ");
    return int.Parse(Console.ReadLine());
}
int[,] FillArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] empty = new int[rows, columns];

    for (int i = 0; i < empty.GetLength(0); i++)
    {
        for (int j = 0; j < empty.GetLength(1); j++)
        {
            empty[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return empty;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void ReplaceRowsOnColumns(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine();
        Console.WriteLine("ERROR! Rows and columns unequal!");
        return;
    }
    else
    {
        int temp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i,j] == array[j,i])break;
                temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
        }
        Console.WriteLine();
        PrintArray(array);
    }
    
}
Main();