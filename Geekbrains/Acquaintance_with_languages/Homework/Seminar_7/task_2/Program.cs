/*
## Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[,]fill = FillArray(GetSizeRows(),GetSizeColumns(),GetMinValue(),GetMaxValue());
    PrintArray(fill);
    SearchNumber(fill, GetNumber());

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
    Console.Write("Введите минимальное значение искомого диапазона для массива: ");
    return int.Parse(Console.ReadLine());
}
int GetMaxValue()
{
    Console.Write("Введите максимальное значение искомого диапазона для массива: ");
    return int.Parse(Console.ReadLine());
}
int[,]FillArray(int rows, int columns, int min, int max)
{
    int[,]empty = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            empty[i,j] = new Random().Next(min,max);
        }
    }
    return empty;
}
void PrintArray(int[,]fill)
{
    for (int i = 0; i < fill.GetLength(0); i++)
    {
        for (int j = 0; j < fill.GetLength(1); j++)
        {
            Console.Write($"{fill[i,j]} <- ");
        }
        Console.WriteLine();
    }
}
int GetNumber()
{
    Console.Write("Введите искомое число: ");
    return int.Parse(Console.ReadLine());
}
void SearchNumber(int[,]fill, int number)
{
    for (int i = 0; i < fill.GetLength(0); i++)
    {
        for (int j = 0; j < fill.GetLength(1); j++)
        {
            if(number == fill[i,j])Console.WriteLine($"Число {number} есть на позиции ({i};{j})!!");
            else Console.WriteLine($"Числа {number} на позиции ({i};{j}) нет!");
        }
    }
    
}
Main();
