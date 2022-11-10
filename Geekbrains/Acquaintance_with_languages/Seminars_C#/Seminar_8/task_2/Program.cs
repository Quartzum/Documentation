﻿void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    Console.WriteLine();

    Console.Write("Введите количество строк двумерного массива: ");
    int rows = GetValue();
    Console.Write("Введите количество столбцов двумерного массива: ");
    int columns = GetValue();
    Console.Write("Введите минимальное значение массива: ");
    int minValue = GetValue();
    Console.Write("Введите максимальное значение массива: ");
    int maxValue = GetValue();

    int[,] fill = FillArray(rows, columns, minValue, maxValue);
    Console.WriteLine();
    PrintArray(fill);
    CheckArray(fill);
    Console.WriteLine();
    Console.WriteLine("End");
}
int GetValue()
{
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
void CheckArray(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine();
        Console.WriteLine("ERROR! Rows and columns unequal!");
        return;
    }
    else ReplaceRowsOnColumns(array);
}
void ReplaceRowsOnColumns(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == array[j, i]) break;
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
    Console.WriteLine();
    PrintArray(array);
}
Main();