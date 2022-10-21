void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[,]fill = FillArray(GetRowSize(),GetColumnSize());
    PrintArray(fill);
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
int[,] FillArray(int rows, int columns)
{
    int[,]empty = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            empty[i,j] = i + j;
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
            Console.Write($"{fill[i,j]} ");
        }
        Console.WriteLine();
    }
}
Main();