void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    Console.Write("Введите число: ");
    int number = GetNumber();
    Console.WriteLine();

    Console.Write($"Сумма числа {number} - {ShowSumNumbers(number)}.");

    Console.WriteLine();
    Console.WriteLine("End");
}
int GetNumber()
{
    return int.Parse(Console.ReadLine());
}
int ShowSumNumbers(int number)
{
    if(number == 0) return 0;

    return number % 10 + ShowSumNumbers(number / 10);
}
Main();