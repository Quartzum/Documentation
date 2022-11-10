/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void Main()
{
    Console.Clear();
    Console.WriteLine();
    Console.Write("Введите количество строк прямоугольного двумерного массива: ");
    int rows = GetValue();
    Console.Write("Введите количество столбцов прямоугольного двумерного массива: ");
    int columns = GetValue();
    Console.Write("Введите минимальное значение массива: ");
    int minValue = GetValue();
    Console.Write("Введите максимальное значение массива: ");
    int maxValue = GetValue();
    Console.WriteLine();

    if(rows == columns)
    {
        Console.WriteLine("Количество строк и столбцов совпадает! Введите корректные значения для прямоугольного двумерного массива!");
        return;
    }
    
    int[,] array = FillArray(rows, columns, minValue, maxValue);
    Console.WriteLine("Текущий массив.");
    Console.WriteLine();
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма элементов на строке - {SearchMinRow(array)}.");
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
void PrintArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          Console.Write($"{array[i,j]} ");  
        }
        Console.WriteLine();
    }
}
int SearchMinRow(int[,]array)
{
    int result = 0;
    int sum = 0;
    int total = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           sum += array[i,j];
        }
        if(total > sum) result = i; 
    }

    result += 1;

    return result;
}
Main();