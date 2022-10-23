void Main()
{
    Console.Clear();
    Console.WriteLine("Start");

    double[,]fill = FillArray(GetSizeRows(),GetSizeColumns());
    PrintArray(fill);

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
double[,]FillArray(int rows, int columns)
{
    double[,]empty = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            empty[i,j] = new Random().NextDouble();
        }
    }
    return empty;
}
void PrintArray(double[,]fill)
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
Main();