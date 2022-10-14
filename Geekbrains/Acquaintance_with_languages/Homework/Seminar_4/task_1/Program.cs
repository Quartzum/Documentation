void Main()
{
    Console.Clear();
    Console.WriteLine("Start");

    int[]array = new int[2];

    FillArray(array);

    Console.WriteLine($"{array[0]} в степени {array[1]} - {Exponentiation(array)}.");
   
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

    int Exponentiation(int[]arg1)
    {
        int result = 1;
        
        while(arg1[1] > 0)
        {
            result *= arg1[0];
            arg1[1]--;
        } 
    
    return result;
    }

    Console.WriteLine("End");
}

Main();