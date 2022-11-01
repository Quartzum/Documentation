void Main()
{
    Console.Clear();
    Console.WriteLine("Start Binary Algortihm");
    int[] array = { 14, 21, 33, 4, 51, 6, 75, 8, 94 };
    PrintArray(array);
    SelectionSort(array);
    Console.WriteLine();
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine("End Binary Algortihm");
}
int[]SelectionSort(int[]array)
{
    int temp = 0;
    int min = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        min = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[min]) min = j;
        }

        temp = array[min];
        array[min] = array[i];
        array[i] = temp;
    }
    return array;
}
void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} <-");
    }
}
Main();