void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[]FillArray = CreateArray(EnterSizeArray(), EnterMinNumber(), EnterMaxNumber());
    Console.WriteLine("Заполненный массив - " + string.Join(" ", FillArray) + ".");

    int[]CompositionArray = Composition(FillArray);
    Console.WriteLine("Массив с произведениями пар чисел - " + string.Join(" ", CompositionArray) + ".");
    Console.WriteLine("End");
}
int EnterSizeArray()
{
    Console.Write("Введите размер массива: ");
    return int.Parse(Console.ReadLine());
}
int EnterMinNumber()
{
    Console.Write("Введите минимальное значение искомого диапазона: ");
    return int.Parse(Console.ReadLine());
}
int EnterMaxNumber()
{
    Console.Write("Введите максимальное значение искомого диапазона: ");
    return int.Parse(Console.ReadLine());
}
int [] CreateArray(int arg1, int arg2, int arg3)
{
    int[]empty = new int[arg1];
    for (int i = 0; i < arg1; i++)
    {
        empty[i] = new Random().Next(arg2, arg3);
    }
    return empty;
}
int [] Composition(int[]arg1)
{
    int[]NewArray = new int[arg1.Length];
    int StartCount = 0;
    int EndCount = arg1.Length -1;
    int CountNewArray = 0;
    
    while(StartCount < arg1.Length)
    {
        NewArray[CountNewArray] = arg1[StartCount] * arg1[EndCount];
        StartCount++;
        EndCount--;
        CountNewArray++;
    }
    return NewArray;
}
Main();