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