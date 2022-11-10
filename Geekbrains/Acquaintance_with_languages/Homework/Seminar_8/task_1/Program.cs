/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    Console.WriteLine();

    Console.Write("Введите количество строк двумерного массива: ");
    int rows = GetValue();
    Console.Write("Введите количество столбцов двумерного массива: ");
    int columns = GetValue();
    Console.Write("Введите минимальное значение двумерного массива: ");
    int minValue = GetValue();
    Console.Write("Введите максимальное значение двумерного массива: ");
    int maxValue = GetValue();
    Console.WriteLine();
    int[,] fill = FillArray(rows, columns, minValue, maxValue);

    PrintArray(fill);
    Console.WriteLine();

    SelectionSort(fill);

    PrintArray(fill);

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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] SelectionSort(int[,] array)
{
    int max = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, j])
                {
                    max = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = max;
                }
            }
        }
    }

    return array;
}
Main();