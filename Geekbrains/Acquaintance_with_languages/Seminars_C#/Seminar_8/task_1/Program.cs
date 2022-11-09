void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[,] fill = FillArray(GetRows(), GetColumns(), GetMinValueArray(), GetMaxValueArray());
    PrintArray(fill);
    ReplaceStartAndEndRows(fill);
    Console.WriteLine();
    PrintArray(fill);
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
int[,] ReplaceStartAndEndRows(int[,] array)
{
    int temp = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        temp = array[0, i];
        array[0, i] = array[array.GetLength(1) - 1, i];
        array[array.GetLength(1) - 1, i] = temp;
    }
    return array;
}
Main();