void Main()
{
    Console.Clear();
    Console.WriteLine("Start");

    int[] newArray = FillArray(10, -5, 5);
    int value = GetNumber();
    EnumerationArray(newArray, value);

    Console.WriteLine("End");
}
int[]FillArray(int size, int minValue, int maxValue)
{
    int[]array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
int GetNumber()
{
    Console.Write("Введите искомое число: ");
    return int.Parse(Console.ReadLine());
}
void EnumerationArray(int[]array, int value)
{
    foreach (int item in array)
    {
        if(item == value) Console.WriteLine($"Искомое число {value} - есть в ячейки!");
        else Console.WriteLine($"Искомое число {value} - нет в ячейки!");
         
    }
}
Main();