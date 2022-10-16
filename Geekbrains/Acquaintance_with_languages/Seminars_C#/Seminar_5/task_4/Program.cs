void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int[] FillArray = CreateArray(123);
    Console.WriteLine($"{FillArray[0]}");
    Console.WriteLine($"{FillArray[3]}");
    

    Console.WriteLine($"{ShowNumber(FillArray)}");

    Console.WriteLine("End");
}
int [] CreateArray(int size)
{
    int [] array = new int [size];
    
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}
int ShowNumber(int[]arg1)
{
    int count = 0;
    foreach (int item in arg1)
    {
        if(item > 10 && item < 99)count++;
    }
    return count;
}
Main();