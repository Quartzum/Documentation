/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    Console.WriteLine("Введите натуральное число: ");
    int number = GetNumber();
    ShowNaturalNumbers(number);

    Console.WriteLine("End");
}

int GetNumber()
{
    return int.Parse(Console.ReadLine());
}

int ShowNaturalNumbers(int number)
{
    if(number < 1) return 1;

    Console.Write($"{number} <- ");

    return ShowNaturalNumbers(number - 1);
}
Main();