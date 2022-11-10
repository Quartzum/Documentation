/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    Console.Write("Введите первое число: ");
    int firstNumber = GetNumber();
    Console.Write("Введите второе число: ");
    int secondNumber = GetNumber();
    Console.WriteLine();
    Console.Write($"Результат возведенья в степень числа {firstNumber} в степень {secondNumber} - {Exponentiation(firstNumber, secondNumber)}.");
    Console.WriteLine();
    Console.WriteLine("End");
}
int GetNumber()
{
    return int.Parse(Console.ReadLine());
}
int Exponentiation(int firstNumber, int secondNumber)
{
    if(secondNumber < 1) return 1;

    return firstNumber * Exponentiation(firstNumber,secondNumber - 1);
}
Main();