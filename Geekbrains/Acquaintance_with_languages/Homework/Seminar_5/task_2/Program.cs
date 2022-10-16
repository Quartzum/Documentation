void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[]fill = FillArray(GetSizeArray(), GetMinNumber(), GetMaxNumber());
    Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях - {SetSummArray(fill)}.");
    Console.WriteLine("End");
}
int GetSizeArray()
{
    Console.Write("Введите размер массива: ");
    return int.Parse(Console.ReadLine());
}
int GetMinNumber()
{
    Console.Write("Введите минимальное значение предела: ");
    return int.Parse(Console.ReadLine());
}
int GetMaxNumber()
{
    Console.Write("Введите максимальное значение предела: ");
    return int.Parse(Console.ReadLine());
}
int[]FillArray(int arg1, int arg2, int arg3)
{
    int[]empty = new int[arg1];
    for (int i = 0; i < empty.Length; i++)
    {
        empty[i] = new Random().Next(arg2, arg3);
    }
    return empty;
}
int SetSummArray(int[]arg1)
{
    int summ = 0;
    for (int i = 0; i < arg1.Length; i++)
    {
        if(i == 1)summ += arg1[i];
        if(i % 2 == 1)summ +=arg1[i];
    }
    return summ;
}
Main();