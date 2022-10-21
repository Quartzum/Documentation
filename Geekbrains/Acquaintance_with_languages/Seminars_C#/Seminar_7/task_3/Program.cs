void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[,] fill = FillArray(GetRowSize(), GetColumnSize(), MinValue(), MaxValue());
    PrintArray(fill);
    Console.WriteLine();
    int[,] change = ChangeArray(fill);
    PrintArray(change);
    Console.WriteLine();
    Console.WriteLine("End");
}
int GetRowSize()
{
    Console.Write("Введите количество строк массива: ");
    return int.Parse(Console.ReadLine());
}
int GetColumnSize()
{
    Console.Write("Введите количество столбцов массива: ");
    return int.Parse(Console.ReadLine());
}
int MinValue()
{
    Console.Write("Введите минимальное значение искомого диапазона: ");
    return int.Parse(Console.ReadLine());
}
int MaxValue()
{
    Console.Write("Введите максимальное значение искомого диапазона: ");
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
int[,] ChangeArray(int[,] fill)
{
    for (int i = 0; i < fill.GetLength(0); i++)
    {
        for (int j = 0; j < fill.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) fill[i, j] *= fill[i, j];
        }
        Console.WriteLine();
    }
    return fill;
}
void PrintArray(int[,] change)
{
    for (int i = 0; i < change.GetLength(0); i++)
    {
        for (int j = 0; j < change.GetLength(1); j++)
        {
            Console.Write($"{change[i,j]} ");
        }
        Console.WriteLine();
    }
}
Main();