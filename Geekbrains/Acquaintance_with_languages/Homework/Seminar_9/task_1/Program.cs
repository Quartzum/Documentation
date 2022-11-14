void Main()
{
    Console.Clear();
    int value = GetValue();
    if (value == 0 || value == 1)
    {
        Console.Write($"Четных чисел от {value} до 1 нет.");
        return;
    }
    ShowSubsequence(value);
}
int GetValue()
{
    Console.Write("Введите значение: ");
    return int.Parse(Console.ReadLine());
}
int ShowSubsequence(int value)
{
    if (value == 1) return 1;

    if (value % 2 == 0) Console.Write($"{value} ");

    return ShowSubsequence(value - 1);
}
Main();