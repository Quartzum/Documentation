void Main()
{
    Console.Clear();
    Console.WriteLine("Start");

    int number = GetNumber();

    PrintTable(number);

    Console.WriteLine();
    Console.WriteLine("End");

    int GetNumber()
    {
        Console.Write("Введите число: ");
        return int.Parse(Console.ReadLine());
    }

    void PrintTable(int arg1)
    {
        while(arg1 >= 1)
        {
            int result = arg1 * arg1 * arg1;
            Console.Write($"{result} <-");
            arg1--;
        }
    
    }

}

Main();