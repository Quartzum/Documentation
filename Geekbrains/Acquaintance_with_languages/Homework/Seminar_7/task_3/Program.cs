/*
## Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[,] fill = FillArray(GetSizeRows(), GetSizeColumns(), GetMinValue(), GetMaxValue());
    PrintArray(fill);
    PrintAverageArifmetic(fill);
    Console.WriteLine("End");
}
int GetSizeRows()
{
    Console.Write("Введите количество строк массива: ");
    return int.Parse(Console.ReadLine());
}
int GetSizeColumns()
{
    Console.Write("Введите количество столбцов массива: ");
    return int.Parse(Console.ReadLine());
}
int GetMinValue()
{
    Console.Write("Введите минимальное значение диапазона массива: ");
    return int.Parse(Console.ReadLine());
}
int GetMaxValue()
{
    Console.Write("Введите максимальное значение диапазона массива: ");
    return int.Parse(Console.ReadLine());
}
int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] empty = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            empty[i, j] = new Random().Next(min, max);
        }
    }
    return empty;
}
void PrintArray(int[,] fill)
{
    for (int i = 0; i < fill.GetLength(0); i++)
    {
        for (int j = 0; j < fill.GetLength(1); j++)
        {
            Console.Write($"{fill[i, j]} <-");
        }
        Console.WriteLine();
    }
}
void PrintAverageArifmetic(int[,] fill)
{
    double[] arif = new double[fill.GetLength(1)];

    for (int i = 0; i < fill.GetLength(1); i++)
    {
        for (int j = 0; j < fill.GetLength(0); j++)
        {
            arif[i] += fill[j,i];
            Console.WriteLine($"Итерация:{i} - {arif[i]}");
        }
    }
    foreach (double item in arif)
    {
        Console.WriteLine($"{item / fill.GetLength(0)} <-");
    }
}
Main();