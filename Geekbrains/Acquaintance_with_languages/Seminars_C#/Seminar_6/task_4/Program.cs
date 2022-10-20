void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    PrintFibbonachi();
    Console.WriteLine("End");
}

void PrintFibbonachi()
{
    int prev = 0;
    int current = 1;
    int temp;

    Console.WriteLine(prev);
    for (int i = 0; i <= 5; i++)
    {
        Console.WriteLine(current);
        temp = current;
        current += prev;
        prev = temp;
    }
}
Main();