/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

void Main()
{
    Console.Clear();
    int firstValue = GetValue();
    int secondValue = GetValue();
    if (firstValue < 0 && secondValue < 0)
    {
        Console.Write("Введите неотрицательное число!");
        return;
    }
    int result = FuncAkkerman(firstValue, secondValue);
        Console.Write($"Результат функции Аккермана - {result}.");

}
int GetValue()
{
    Console.Write("Введите неотрицательное число: ");
    return int.Parse(Console.ReadLine());
}
int FuncAkkerman(int firstValue, int secondValue)
{
    if (firstValue == 0) return secondValue + 1;
    if (firstValue != 0 && secondValue == 0) return FuncAkkerman(firstValue - 1, 1);
    if (firstValue > 0 && secondValue > 0) return FuncAkkerman(firstValue - 1, FuncAkkerman(firstValue, secondValue - 1));
    return FuncAkkerman(firstValue, secondValue);
}
Main();