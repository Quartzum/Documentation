void Main()
{

Console.Clear();
Console.WriteLine("Start");

int [] array = GetArray(10, -9, 9);
int [] newArray = ChangeArray(array);

Console.WriteLine();
Console.WriteLine("End");
}
int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int [] ChangeArray(int[]array)
{
    int count = 0;
    foreach (int el in array)
    {
        array[count] = el * -1;
        count++;
    }
    Console.WriteLine();
    Console.Write(string.Join(" ", array));
    return array;
}
Main();