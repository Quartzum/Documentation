void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[]FillArray = CreateArray(EnterSizeArray(), EnterMinNumber(), EnterMaxNumber());
    Console.Write(string.Join(" ", FillArray));
    Console.WriteLine($"{Composition(FillArray)}");


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
    int[]array = new int[arg1];
    for (int i = 0; i < arg1; i++)
    {
        array[i] = new Random().Next(arg2, arg3);
    }
    return array;
}
int Composition(int[]arg1)
{
    int CountStart = 0;
    int CountEnd = arg1.Length-1;
    int result = 0;
    while (CountStart == CountEnd)
    {
        result = arg1[CountStart] * arg1[CountEnd];
        CountStart++;
        CountEnd--;
    }
    Console.WriteLine();
    Console.WriteLine($"{CountEnd}");
    Console.WriteLine($"{CountStart}");
    return result;
}
Main();