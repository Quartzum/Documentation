void Main()
{
    Console.WriteLine("Start");
    int[] fillArray = FillArray();
    
    PrintArray(fillArray);

    Console.WriteLine("End");
}
int[]FillArray()
{
    int[]array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}
void PrintArray(int[]arg1)
{
    Console.WriteLine(string.Join(" ", arg1));
}
Main();