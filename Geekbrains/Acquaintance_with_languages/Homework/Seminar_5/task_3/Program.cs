void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    double[]fill = FillArray(GetSizeArray(), GetMinNumber(), GetMaxNumber());
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива - {DifferenceNumbers(fill)}.");
    Console.WriteLine("End");
}
int GetSizeArray()
{
    Console.Write("Введите размер массива: ");
    return int.Parse((Console.ReadLine()));
}
double GetMinNumber()
{
    Console.Write("Введите минимальное значение предела: ");
    return Convert.ToDouble(Console.ReadLine());
}
double GetMaxNumber()
{
    Console.Write("Введите максимальное значение предела: ");
    return Convert.ToDouble(Console.ReadLine());
}
double[]FillArray(int arg1, double arg2, double arg3)
{
    double[]empty = new double[arg1];
    for (int i = 0; i < empty.Length; i++)
    {
        empty[i] = (new Random().NextDouble() * (arg3 - arg2));
    }
    return empty;
}
double DifferenceNumbers(double[]arg1)
{
    double result = 0;
    double min = arg1[0];
    double max = arg1[0];
    foreach (double item in arg1)
    {
        if(max < item) max = item;
    }
    Console.WriteLine(max);
    foreach (double item in arg1)
    {
        if(min > item) min = item;
    }
    Console.WriteLine(min);
    
    return result = max - min;
}
Main();