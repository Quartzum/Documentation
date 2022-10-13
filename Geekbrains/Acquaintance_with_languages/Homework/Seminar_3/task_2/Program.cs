void Main()
{
    Console.Clear();
    Console.WriteLine("Start");

    int[]EmptyArray = new int[6];
    int[]FillArray = SetCoordinateInArray(EmptyArray);
    int[]RootExtraction = new int[8];

    CalculateSubstraction(FillArray, RootExtraction);

    CalculateAbs(RootExtraction);

    CalculateSum(RootExtraction);

    CalculateRootExtraction(RootExtraction, FillArray);

    Console.WriteLine("End");
    
    
    int GetCoordinate()
    {
        Console.Write("Введите координату: ");
        return int.Parse(Console.ReadLine());
    }

    int[] SetCoordinateInArray(int[]arg1)
    {
        for(int i = 0; arg1.Length > i ; i++)
        {
            arg1[i] = GetCoordinate();
        }
        return arg1;
    }

    int[] CalculateSubstraction(int[]arg1, int[]arg2)
    {
        arg2[0] = arg1[0] - arg1[1];
        arg2[1] = arg1[2] - arg1[3];
        arg2[2] = arg1[4] - arg1[5];
        return arg2;
    }

    int[] CalculateAbs(int[]arg1)
    {
        arg1[3] = arg1[0] * arg1[0];
        arg1[4] = arg1[1] * arg1[1];
        arg1[5] = arg1[2] * arg1[2];
        return arg1;
    }

    int[] CalculateSum(int[]arg1)
    {
        arg1[6] = arg1[3] + arg1[4] + arg1[5];
        return arg1;
    }
    
    void CalculateRootExtraction(int[]arg1, int[]arg2)
    {
        double convert = Convert.ToDouble(arg1[6]);
        double result = Math.Sqrt(convert);
        Console.WriteLine($"Расстояние между точками: ({arg2[0]});({arg2[1]}), ({arg2[2]});({arg2[3]}), ({arg2[4]});({arg2[5]})  - {result}.");
    }

}

Main();