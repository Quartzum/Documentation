void Main()
{
    Console.Clear();
    Console.WriteLine();
    Console.Write("Введите количество строк квадратной матрицы: ");
    int rows = GetValue();
    Console.Write("Введите количество столбцов квадратной матрицы: ");
    int columns = GetValue();
    Console.Write("Введите минимальное значение матрицы: ");
    int minValue = GetValue();
    Console.Write("Введите максимальное значение матрицы: ");
    int maxValue = GetValue();
    Console.WriteLine();

    if (rows != columns)
    {
        Console.WriteLine("Матрицы должны быть равны по количеству строк и столбцов! Введите корректное значение!");
        return;
    }

    int[,] firstMatrix = FillArray(rows, columns, minValue, maxValue);
    int[,] secondMatrix = FillArray(rows, columns, minValue, maxValue);
    Console.WriteLine("Первая матрица.");
    Console.WriteLine();
    PrintArray(firstMatrix);
    Console.WriteLine();
    Console.WriteLine("Первая матрица.");
    Console.WriteLine();
    PrintArray(secondMatrix);
    Console.WriteLine();

    Console.WriteLine("Результат: ");
    Console.WriteLine();
    PrintArray(CompositionMatrix(firstMatrix, secondMatrix));
    Console.WriteLine();
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
int[,] CompositionMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];

    

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            result[i, j] = 0;

            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                result[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }

    return result;
}
Main();