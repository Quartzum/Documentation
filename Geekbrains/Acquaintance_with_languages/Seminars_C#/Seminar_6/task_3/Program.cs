/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10

*/

void Main()
{
    Console.Clear();
    Console.WriteLine("Start");
    ChangeNumber(GetNumber());
    Console.WriteLine();
    Console.WriteLine("End");
}

int GetNumber()
{
    Console.Write("Введите число: ");
    return int.Parse(Console.ReadLine());
}

void ChangeNumber(int arg1)
{
    string empty =
    for(int i = 0; arg1 > 0; i++)
    {
        int result = arg1 % 2;
        arg1 /= 2;
        empty[i] = result;
    }
    for (int i = 0; i < empty.Length; i++)
    {
        Console.Write($"{empty[]}");
    }
}

Main();