/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

*/

void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    Console.WriteLine($"{CheckTriangle(GetNumber(),GetNumber(),GetNumber())}");
    Console.WriteLine("End");
}
int GetNumber()
{
    Console.Write("Введите число: ");
    return int.Parse(Console.ReadLine());
}
bool CheckTriangle(int arg1, int arg2, int arg3)
{
    bool result;
    if(arg1 < arg2 + arg3 && arg2 < arg1 + arg3 && arg3 < arg1 + arg3) return result = true;
    else return result = false;
}

Main();