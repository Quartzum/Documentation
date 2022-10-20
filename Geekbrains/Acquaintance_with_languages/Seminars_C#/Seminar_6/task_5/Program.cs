void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[]fill = FillArray(GetSize());
    int[]CopyFill = CopyArray(fill);
    Console.WriteLine("End");
}
int GetSize()
{
    Console.WriteLine("Введите размер массива: ");
    return int.Parse(Console.ReadLine());
}
int[]FillArray(int arg1)
{
    int[]empty = new int[arg1];
    for (int i = 0; i < arg1; i++)
    {
        empty[i] = new Random().Next();
    }
    return empty;
}
int[]CopyArray(int[]arg1)
{
    int[]newArray = new int[arg1.Length];
    int count = 0;
    foreach (int item in arg1)
    {
        newArray[count] = item;
        count++;
    }
    return newArray;
}

Main();