/*
## Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

void Main()
{
    Console.Clear();
    Console.WriteLine("Start");

    Console.WriteLine("End");
}

int[]CalculateUserReadNumber()
{
    int i = 0;
    int[]temp = new int[i];
    string empty = "";

    while(true)
    {
        Console.WriteLine("Enter number: ");
        temp[i] = int.Parse(Console.ReadLine());
        Console.WriteLine("Contunue enter numbers? Yes/No.");
        empty = Console.ReadLine();
        if(empty == "No" || empty == "no" || empty = "n")return;
        
    }
    
    return temp;
}