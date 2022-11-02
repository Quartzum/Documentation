// Рекурсивный алгоритм нахождения Факториала

void Main()
{
    Console.Clear();
    Console.WriteLine("Start Recursion");
    int searching = GetNumber();
    Console.WriteLine($"Факториал числа - {searching}: {Recursion(searching)}.");
    Console.WriteLine("End Recursion");
}
int GetNumber()
{
    Console.Write("Введите число, для которого, необходимо вычислить факториал: ");
    return int.Parse(Console.ReadLine());
}
int Recursion(int number)
{
    if(number == 1) return 1; // Базовый случай выхода из функции.
    else return number * Recursion(number - 1); // Рекурсивный вызов.
}
Main();
// Начиная с числа 17 - появляются ошибки.