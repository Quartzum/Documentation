void Main()
{
    Console.Clear();
    Console.WriteLine("Start");

    int[]empty= new int[2];
    int[]fill = FillArray(empty);
    Console.WriteLine();

    Console.WriteLine($"{fill[0]} в степени {fill[1]} - {Exponentiation(fill)}.");

    Console.WriteLine("End");
}
int GetNumber()
{
    Console.Write("Введите число: ");
    return int.Parse(Console.ReadLine());
}
int[]FillArray(int[]arg1)
{
    arg1[0] = GetNumber();
    arg1[1] = GetNumber();
    return arg1;
}
decimal Exponentiation(int[]arg1)
{
    decimal result = 1;

    if(arg1[1] > 0)
    {
    for (int i = 0; i < arg1[1]; i++)
    {
        result *= arg1[0];
    }
    }

    else if(arg1[1] < 0)
    {
    for (int i = 0; i > arg1[1]; i++)
    {
        if(arg1[1] == 0) break;
        result *= arg1[0];
        arg1[1]++;
    }
        result = 1 / result;
    }

    return result;
}
Main();