void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    Console.WriteLine();
    int[,] fill = FillArray(GetRows(), GetColumns(), GetMinValueArray(), GetMaxValueArray());
    Console.WriteLine();
    PrintArray(fill);
    CalculateCountNumberInArray(fill);
    Console.WriteLine();
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
void CalculateCountNumberInArray(int[,] array)
{
    int countArray = 0;
    int countTemp = 0;

    int[,] temp = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            foreach (var item in array)
            {
                if (array[i, j] == item) countArray++;
            }

            temp[i, j] = array[i, j];

            foreach (var item in temp)
            {
                if (array[i, j] == item) countTemp++;
                else if (countTemp >= 2) break;
            }

            if (countTemp >= 2)
            {
                countArray = 0;
                countTemp = 0;
            }
            else
            Console.WriteLine($"Число {array[i, j]} встречается в массиве {countArray} раз!");
            countTemp = 0;
            countArray = 0;
        }
    }
}
Main();