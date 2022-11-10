/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    Console.Write("Введите натуральное число, от которого будет выводится последовательность: ");
    int start = GetNumber();
    Console.Write("Введите натуральное число, до которого будет выводится последовательность: ");
    int end = GetNumber();
    Console.WriteLine();
    ShowSubsequence(start, end);
    Console.WriteLine();
    Console.WriteLine("End");
}

int GetNumber()
{
    return int.Parse(Console.ReadLine());
}

int ShowSubsequence(int start, int end)
{
    if(start > end) return end;

    Console.Write($"{start} <- ");
    
    return ShowSubsequence(start + 1, end);
}
Main();