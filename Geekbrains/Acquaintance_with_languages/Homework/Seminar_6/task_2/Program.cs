void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    CheckIntersection(GetNumber(), GetNumber(), GetNumber(), GetNumber());
    Console.WriteLine("End");
}
double GetNumber()
{
    Console.Write("Введите координату: ");
    return Convert.ToDouble(Console.ReadLine());
}
void CheckIntersection(double b1, double k1, double b2, double k2)
{
    double x = -(b1-b2)/(k1-k2);
    double y = k1 * x + b1;

    x = Math.Round(x, 3);
    y = Math.Round(y, 3);

    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}
Main();