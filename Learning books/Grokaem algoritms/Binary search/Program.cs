// Классический линейный алгоритм

void MainOne()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[] = {1,2,3,4,5,6,7,8,9};
    int searching = 4;
    int count = LinearSearch(array, searching);
    Console.WriteLine($"Количество итераций = {count}");

    Console.WriteLine("End");
}

int LinearSearch(int[]array, int searching)
{
    int count = 0;
    while(count < array.Length)
    {
        if(array[count] = searching) return count;
        count++;
    }
    return -1;
}
MainOne();

//Бинарный алгоритм
void MainTwo()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[]array = {1,2,3,4,5,6,7,8,9};
    int searching = 4;
    int count = LinearSearch(array, searching);
    Console.WriteLine($"Количество итераций = {count}");

    Console.WriteLine("End");
}

int LinearSearch(int[]array, int searching)
{
    int count = 0;
    while(count < array.Length)
    {
        if(array[count] = searching) return count;
        count++;
    }
    return -1;
}
Main();