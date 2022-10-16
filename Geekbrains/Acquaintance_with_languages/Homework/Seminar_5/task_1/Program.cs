void Main()
{
    Console.Clear();
    Console.WriteLine("Start");

    int [] fill = FillArray(GetSizeArray());
    Console.WriteLine($"Количество четных чисел в массиве - {ShowNumber(fill)}.");

    Console.WriteLine("End");
}
int GetSizeArray()
{
    Console.Write("Введите размер массива: ");
    return int.Parse(Console.ReadLine());
}
int [] FillArray(int arg1)
{
    int[]array = new int[arg1];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,999);
    }
    return array;
}
int ShowNumber(int [] arg1)
{
    int count = 0;
    foreach (int item in arg1)
    {
        if(item % 2 == 0) count++;
    }
    return count;
}
Main();