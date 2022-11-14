void Main()
{
    Console.Clear();
    int firstValue = GetValue();
    int secondValue = GetValue();
    int result = ShowSubsequence(firstValue, secondValue);
    Console.WriteLine($"Сумма элементов от {firstValue} до {secondValue} - {result}.");
}
int GetValue()
{
    Console.Write("Введите значение: ");
    return int.Parse(Console.ReadLine());
}
int ShowSubsequence(int firstValue, int secondValue)
{
    if (secondValue == firstValue)return 1;
    return secondValue + ShowSubsequence(firstValue, secondValue - 1);
}
Main();