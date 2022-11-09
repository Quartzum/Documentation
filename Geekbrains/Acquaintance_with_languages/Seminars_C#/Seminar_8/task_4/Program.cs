void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    int amount = GetAmountString();
    ShowTriangle(amount);
    Console.WriteLine("End");

}
int GetAmountString()
{
    Console.Write("Enter the number of rows: ");
    return int.Parse(Console.ReadLine());
}
void ShowTriangle(int amount)
{
    for (int i = 0; i < amount; i++)
    {
        int c = 1;
        for (int j = 0; j < amount - i; j++)
        {
            Console.Write("   ");
        }

        for (int z = 0; z <= i; z++)
        {
            Console.Write("   {0:D} ", c);
            c = c * (i - z) / (z + 1);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
}
Main();

