void Main()
{
    Console.Clear();
    Console.WriteLine("Start");

    int number = GetNumber();
    int summ = PrintSumNumbers(number);
    Console.WriteLine($"Сумма цифр числа - {number} - > {summ}.");

    Console.WriteLine("End");
}
int GetNumber()
{
    Console.Write("Введите число: ");
    return int.Parse(Console.ReadLine());
}
int PrintSumNumbers(int arg1){
    int result = 0;

    if(arg1 > 0)
    {
        while (arg1 > 0)
    {
        int remainder = arg1 % 10;
        result += remainder;
        arg1 /= 10;
    }
    }
    else arg1 *= -1;
        while (arg1 > 0)
    {
        int remainder = arg1 % 10;
        result += remainder;
        arg1 /= 10;
    }
    return result;
}
Main();